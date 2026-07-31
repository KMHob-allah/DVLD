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

        static public bool HasAnyAppointment(int LocalAppID)
        {
            bool HasAppointment = false;

            string Query = @"SELECT Case 
                            WHEN EXISTS(SELECT 1 FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalAppID) 
                            THEN 1 ELSE 0 END";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                    Connection.Open();

                    HasAppointment = Convert.ToBoolean(Command.ExecuteScalar());
                }
            }
            return HasAppointment;
        }
        static public bool HasAppointmentForTestType(int LocalAppID, bool Active, int TestTypeID)
        {
            bool HasAppointment = false;
            string Query = @"SELECT HasAppointmentForTestType = Case 
                            WHEN EXISTS(SELECT 1 FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalAppID AND TestTypeID = @TestTypeID AND IsLocked = @Acitve) 
                            THEN 1 ELSE 0 END"; 
            
            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                    Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    Command.Parameters.AddWithValue("@Active", (Active ? 0:1));
                    Connection.Open();

                    HasAppointment = Convert.ToBoolean(Command.ExecuteScalar());
                }
            }
            return HasAppointment;
        }

        static public bool IsLicenseIssued(int PersonID, int LicenseClassID)
        {
            return LoadActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1;
        }

        static private int LoadActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            return clLicenseData.LoadActiveLicenseIDByPersonID(PersonID, LicenseClassID);
        }

        static public bool DoesPassedTestType(int LocalAppID, int TestTypeID)
        {
            bool DoesPassedTestType = false;

            string Query = @"IF EXISTS (SELECT 1 FROM Tests T
                            INNER JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID
                            WHERE TA.LocalDrivingLicenseApplicationID = @LocalAppID AND TA.TestTypeID = @TestTypeID AND T.TestResult = 1)
                            BEGIN SELECT 1;
                            END
                            ELSE 
                            BEGIN SELECT 0;
                            END";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                    Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    Connection.Open();

                    DoesPassedTestType = Convert.ToBoolean(Command.ExecuteScalar());                    
                }
            }

            return DoesPassedTestType   ;
        }
        static public bool DoesAttendTestType(int LocalAppID, int TestTypeID)
        {
            bool DoesAttendTestType = false;

            string Query = @"IF EXISTS (SELECT 1 FROM Tests T
                            INNER JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID
                            WHERE TA.LocalDrivingLicenseApplicationID = @LocalAppID AND TA.TestTypeID = @TestTypeID)
                            BEGIN SELECT 1;
                            END
                            ELSE 
                            BEGIN SELECT 0;
                            END";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                    Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    Connection.Open();

                    DoesAttendTestType = Convert.ToBoolean(Command.ExecuteScalar());
                }
            }

            return DoesAttendTestType;
        }

        static public int TotalTrailsPerTest(int LocalAppID, int TestTypeID)
        {
            int TotalTrailsPerTest = 0;

            string Query = @"SELECT COUNT(*)  FROM Tests T
                            INNER JOIN TestAppointments TA ON  TA.TestAppointmentID = T.TestAppointmentID
                            WHERE TA.LocalDrivingLicenseApplicationID = @LocalAppID AND TA.TestTypeID = @TestTypeID";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                    Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    Connection.Open();

                    object Result = Command.ExecuteScalar();

                    if(Result !=  null) TotalTrailsPerTest = Convert.ToInt32(Result);
                }
            }

            return TotalTrailsPerTest;
        }

        static public bool IsThereAnActiveScheduledTest(int LocalAppID, int TestTypeID)
        {
            bool HasActiveSchduledTest = false;

            string Query = @"IF EXISTS(
                            SELECT 1 FROM TestAppointments TA 
                            WHERE LocalDrivingLicenseApplicationID = @LocalAppID AND TestTypeID = @TestTypeID AND IsLocked = 0)
                            RETURN 1;
                            RETURN 0;";
                              

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                    Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    Connection.Open();

                     HasActiveSchduledTest = Convert.ToBoolean(Command.ExecuteScalar());
                }
            }

            return HasActiveSchduledTest;
        }
    }
}
