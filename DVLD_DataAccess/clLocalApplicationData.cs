using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clLocalApplicationData
    {
        static public DataTable LoadLocalAppsList()
        {
            string Query = @"SELECT * FROM LocalDrivingLicenseApplications_View";

            DataTable dtLocalDrivingAppList = new DataTable();

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtLocalDrivingAppList.Load(Reader);
                }
            }

            return dtLocalDrivingAppList;
        }

        static public bool LoadLocalApp(int LocalApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM LocalDrivingLicenseApplications DL
                            WHERE DL.[LocalDrivingLicenseApplicationID] = @LocalApplicationID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            ApplicationID = Convert.ToInt32(Reader["ApplicationID"]);
                            LicenseClassID = Convert.ToInt32(Reader["LicenseClassID"]);
                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
        static public bool LoadLocalApp(ref int LocalApplicationID, int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM LocalDrivingLicenseApplications DL
                            WHERE DL.ApplicationID = @ApplicationID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            LocalApplicationID = Convert.ToInt32(Reader["LocalDrivingLicenseApplicationID"]);
                            LicenseClassID = Convert.ToInt32(Reader["LicenseClassID"]);
                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }

        static public int AddNewLocalApp(int ApplicationID, int LicenseClassID)
        {
            int _LocalApplicationID;

            string Query = @"INSERT INTO  LocalDrivingLicenseApplications                           
                           (ApplicationID,LicenseClassID)
                           VALUES
                           (@ApplicationID,@LicenseClassID);
                           SELECT SCOPE_IDENTITY()";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                Connection.Open();
                _LocalApplicationID = Convert.ToInt32(Command.ExecuteScalar());

            }

            return _LocalApplicationID;
        }
        static public bool UpdateLocalApp(int LocalAppID, int ApplicationID, int LicenseClassID)
        {
            int AffectedRows = 0;

            string Query = @"Update  LocalDrivingLicenseApplications                          
                           SET LicenseClassID = @LicenseClassID
                           WHERE LocalDrivingLicenseApplicationID = @LocalAppID AND ApplicationID = @ApplicationID";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                Connection.Open();

                AffectedRows = Command.ExecuteNonQuery();

            }

            return ApplicationID != 0;
        }
        static public bool DeleteLocalApp(int LocalAppID)
        {
            int RowsAffected = 0;    
            
            string Query = @"Delete From LocalDrivingLicenseApplications                           
                             Where LocalDrivingLicenseApplicationID = @LocalAppID";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);

                Connection.Open();
               
                RowsAffected = Command.ExecuteNonQuery();                              

            }

            return RowsAffected != 0;
        }
        
    }
}
