using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Data
{
    public class clTestData
    {
        static public DataTable LoadAllTests()
        {
            string Query = @"SELECT * FROM Tests";

            DataTable dtTestsList = new DataTable();

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtTestsList.Load(Reader);
                }
            }

            return dtTestsList;
        }
        static public bool LoadTest(int TestID, ref int TestAppointmentID, ref bool TestResult,
                ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Tests T WHERE T.TestID = @TestID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", TestID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            TestAppointmentID = Convert.ToInt32(Reader["TestAppointmentID"]);
                            TestResult = Convert.ToBoolean(Reader["TestResult"]);
                            Notes = Reader["Notes"].ToString();
                            CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
        static public bool LoadTestForPerson(int PersonID, int TestTypeID, int LicenseClassID, ref int TestID, 
            ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {       
            bool IsFound = false;

            string Query = @"SELECT Top 1 *  FROM Tests T 
                            INNER JOIN TestAppointments TA ON TA.TestAppointmentID = T.TestAppointmentID
                            INNER JOIN LocalDrivingLicenseApplications LDLA ON LDLA.LocalDrivingLicenseApplicationID = TA.LocalDrivingLicenseApplicationID
                            INNER JOIN Applications A ON A.ApplicationID = LDLA.ApplicationID
                            WHERE A.ApplicantPersonID @PersonID = AND TA.TestTypeID =@TestTypeID AND LDLA.LicenseClassID = @LicenseClassID
                            ORDER BY TA.TestAppointmentID DESC";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            TestID = Convert.ToInt32(Reader["TestID"]);
                            TestAppointmentID = Convert.ToInt32(Reader["TestAppointmentID"]);
                            TestResult = Convert.ToBoolean(Reader["TestResult"]);
                            Notes = Reader["Notes"].ToString();
                            CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
       
        static public int AddTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int _TestID = -1;

            string Query = @"INSERT INTO Tests                             
                           (TestAppointmentID,
                            TestResult,
                            Notes,
                            CreatedByUserID)
                           VALUES
                           (@TestAppointmentID,
                            @TestResult,
                            @Notes,
                            @CreatedByUserID);
                            UPDATE TestAppointments SET TestAppointments.IsLocked = 1 WHERE TestAppointmentID = @TestAppointmentID;
                            SELECT SCOPE_IDENTITY();";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                Command.Parameters.AddWithValue("@TestResult", TestResult);
                Command.Parameters.AddWithValue("@Notes", Notes);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                Connection.Open();
                _TestID = Convert.ToInt32(Command.ExecuteScalar());
            }

            return _TestID;
        }
        static public bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int RowsAffected = 0;
            
            string Query = @"Update Tests 
                            Set TestAppointmentID = @TestAppointmentID, TestResult = @TestResult, Notes = @Notes, CreatedByUserID = @CreatedByUserID
                            WHERE TestID = @TestID;";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@TestID", TestID);
                Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                Command.Parameters.AddWithValue("@TestResult", TestResult);
                Command.Parameters.AddWithValue("@Notes", Notes);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                Connection.Open();
                RowsAffected = Convert.ToInt32(Command.ExecuteNonQuery());

            }

            return RowsAffected > 0;
        }

        static public int PassedTestCount(int LocalAppID)
        {
           int PassedTests = 0;
            
           string Query = @"SELECT PassedTestCount = COUNT(TestTypeID)
                         FROM Tests T INNER JOIN
                         TestAppointments ON T.TestAppointmentID = TestAppointments.TestAppointmentID
						 where LocalDrivingLicenseApplicationID = @LocalAppID and TestResult=1";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);        

                Connection.Open();
                PassedTests = Convert.ToInt32(Command.ExecuteScalar());
            }

            return PassedTests;
        }
    }
}
