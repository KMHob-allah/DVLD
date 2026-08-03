using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class clApplicationData
    {

        static public DataTable LoadAllApplications()
        {
            DataTable dtPeopleList = new DataTable();

            string Query = @"SELECT * FROM Applications";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtPeopleList.Load(Reader);
                }
            }

            return dtPeopleList;
        }

        static public bool LoadApplication(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate,
                ref byte ApplicationType, ref byte ApplicationStatus,
                ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Applications A WHERE A.ApplicationID = @ApplicationID";

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
                            ApplicantPersonID = Convert.ToInt32(Reader["ApplicantPersonID"]);
                            ApplicationDate = (DateTime)Reader["ApplicationDate"];
                            ApplicationType = Convert.ToByte(Reader["ApplicationTypeID"]);
                            ApplicationStatus = Convert.ToByte(Reader["ApplicationStatus"]);
                            LastStatusDate = (DateTime)Reader["LastStatusDate"];
                            PaidFees = Convert.ToSingle(Reader["PaidFees"]);
                            CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }

        static public int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, byte ApplicationType,
              byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            int _ApplicationID;

            string Query = @"INSERT INTO 
                           Applications 
                           (ApplicantPersonID,ApplicationDate,ApplicationStatus,LastStatusDate, ApplicationTypeID, PaidFees,CreatedByUserID)
                           VALUES
                           (@ApplicantPersonID,@ApplicationDate,@ApplicationStatus,@LastStatusDate,@ApplicationTypeID, @PaidFees,@CreatedByUserID);
                           SELECT SCOPE_IDENTITY()";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationType);
                Command.Parameters.AddWithValue("@PaidFees", PaidFees);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                Connection.Open();

                _ApplicationID = Convert.ToInt32(Command.ExecuteScalar());

            }

            return _ApplicationID;
        }

        static public bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, byte ApplicationType,
             byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            int AffectedRows = 0;

            string Query = @"Update Applications                             
                           Set ApplicantPersonID = @ApplicantPersonID,
                               ApplicationDate = @ApplicationDate,
                               ApplicationStatus = @ApplicationStatus,
                               LastStatusDate = @LastStatusDate,
                               ApplicationTypeID = @ApplicationTypeID,
                               PaidFees = @PaidFees,
                               CreatedByUserID = @CreatedByUserID WHERE ApplicationID = @ApplicationID";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationType);
                Command.Parameters.AddWithValue("@PaidFees", PaidFees);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                Connection.Open();

                AffectedRows = Command.ExecuteNonQuery();

            }

            return AffectedRows != 0;
        }

        static public bool DeleteApplication(int ApplicationID)
        {
            int RowsAffected;

            string Query = @"Delete From Applications Where ApplicationID = @ApplicationID";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                Connection.Open();
                
                RowsAffected = Command.ExecuteNonQuery();                               
            }

            return RowsAffected != 0;
        }

        static public bool IsApplicationExist(int ApplicationID)
        {
            object Result = null;

            string Query = "SELECT 1 FROM Applications WHERE ApplicationID = @ApplicationID";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    Connection.Open();
                    Result = Command.ExecuteScalar();
                }
            }

            return Result != null;
        }

        static public bool PersonHasActiveApp(int ApplicantPersonID, byte ApplicationTypeID)
        {
            object Result = null;

            string Query = @"SELECT 1 FROM Applications A 
                             WHERE A.PersonID = @PersonID AND A.ApplicationTypeID = @ApplicationTypeID And A.ApplicationStatus = 1";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@PersonID", ApplicantPersonID);
                    Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                    Connection.Open();
                    Result = Command.ExecuteScalar();
                }
            }

            return Result != null;
        }

        // I Prefer To Put This Function To Local Driving License Application Data
        static public bool PersonHasActiveAppForLicenseClass(int ApplicantPersonID, byte ApplicationTypeID, int LicenseClassID)
        {
            object Result = null;

            string Query = @"SELECT 1 FROM Applications App
                            INNER JOIN LocalDrivingLicenseApplications LDLA ON App.ApplicationID = LDLA.ApplicationID 
                            WHERE App.ApplicantPersonID = @ApplicantPersonID  
                            AND App.ApplicationTypeID = @ApplicationTypeID
                            AND LDLA.LicenseClassID = @LicenseClassID 
                            AND App.ApplicationStatus = 1;
";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                    Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    Connection.Open();
                    Result = Command.ExecuteScalar();
                }
            }

            return Result != null;
        }
      
        // I Prefer To Put This Function To Local Driving License Application Data        

        static public bool UpdateAppStatus(int ApplicationID, byte NewStatus)
        {
            int RowsAffected;

            string Query = @"Update Applications 
                            Set ApplicationStatus = @ApplicationStatus, LastStatusDate = @LastStatusDate
                            Where ApplicationID = @ApplicationID";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                Command.Parameters.AddWithValue("@ApplicationStatus", NewStatus);
                Command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);


                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }

            return RowsAffected != 0;
        }

    }
}
