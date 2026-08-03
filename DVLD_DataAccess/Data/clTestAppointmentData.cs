using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clTestAppointmentData
    {
        static public DataTable LoadAllAppointmentsListForLocalApp(int LocalAppID, int TestTypeID)
        {
            string Query = @"SELECT 
                            TestAppointmentID, 
                            AppointmentDate,
                            PaidFees,
                            IsLocked 
                            FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalAppID AND TestTypeID = @TestTypeID";

            DataTable dtTestAppointmentsList = new DataTable();

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                    Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtTestAppointmentsList.Load(Reader);
                }
            }

            return dtTestAppointmentsList;
        }
        static public DataTable LoadAllAppointmentsList()
        {
            string Query = @"SELECT * FROM TestAppointments_View";

            DataTable dtTestAppointmentsList = new DataTable();

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtTestAppointmentsList.Load(Reader);
                }
            }

            return dtTestAppointmentsList;
        }

        static public bool LoadLastTestAppointment(ref int TestAppointmentID, int TestTypeID,
                int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID,
                ref bool IsLocked, ref int? RetakeTestAppID)
        {
            bool IsFound = false;

            string Query = @"SELECT TOP 1 * FROM TestAppointments 
                            WHERE TestAppointmentID = @TestAppointmentID AND TestTypeID = @TestTypeID 
                            ORDER BY AppointmentDate DESC;";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    TestAppointmentID = Convert.ToInt32(Reader["TestAppointmentID"]);
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = Convert.ToSingle(Reader["PaidFees"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    IsLocked = Convert.ToBoolean(Reader["IsLocked"]);

                    if (Reader["RetakeTestAppID"] == DBNull.Value) RetakeTestAppID = null;
                    else RetakeTestAppID = Convert.ToInt32(Reader["RetakeTestAppID"]);

                }
            }

            return IsFound;
        }

        static public bool LoadTestAppointment(int TestAppointmentID, ref int TestTypeID,
                ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID,
                ref bool IsLocked, ref int RetakeTestAppID)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    TestTypeID = Convert.ToInt32(Reader["TestTypeID"]);
                    LocalDrivingLicenseApplicationID = Convert.ToInt32(Reader["LocalDrivingLicenseApplicationID"]);
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = Convert.ToSingle(Reader["PaidFees"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    IsLocked = Convert.ToBoolean(Reader["IsLocked"]);

                    if (Reader["RetakeTestAppID"] == DBNull.Value) RetakeTestAppID = -1;
                    else RetakeTestAppID = Convert.ToInt32(Reader["RetakeTestAppID"]);

                }
            }

            return IsFound ;
        }

        static public int AddNew(int TestTypeID, int LocalDrivingLicenseApplicationID,
                DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestAppID)
        {
            int _TestAppointmentID = -1;

            string Query = @"INSERT INTO TestAppointments                             
                           (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppID)
                           VALUES
                           (@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked, @RetakeTestAppID);
                           SELECT SCOPE_IDENTITY();";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                Command.Parameters.AddWithValue("@PaidFees", PaidFees);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                Command.Parameters.AddWithValue("@IsLocked", IsLocked);

                if(RetakeTestAppID == null)
                {
                    Command.Parameters.AddWithValue("@RetakeTestAppID", DBNull.Value);
                }
                else Command.Parameters.AddWithValue("@RetakeTestAppID", RetakeTestAppID);


                Connection.Open();
                _TestAppointmentID = Convert.ToInt32(Command.ExecuteScalar());
            }

            return _TestAppointmentID;
        }

        static public bool Update(int TestAppointmentID, int TestTypeID,
                int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestAppID)
        {
            int RowsAffected;

            string Query = @"Update TestAppointments 
                            Set TestTypeID = @TestTypeID, LocalDrivingLicenseApplicationID= @LocalDrivingLicenseApplicationID,
                            AppointmentDate = @AppointmentDate, PaidFees = @PaidFees, CreatedByUserID = @CreatedByUserID,
                            IsLocked = @IsLocked, RetakeTestApplicationID = @RetakeTestAppID
                            WHERE TestAppointmentID = @TestAppointmentID";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                Command.Parameters.AddWithValue("@PaidFees", PaidFees);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                Command.Parameters.AddWithValue("@IsLocked", IsLocked);
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestAppID);

                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }

            return RowsAffected != 0;
        }

        static public int LoadTestID(int TestAppointmentID)
        {
            int TestID = -1;

            string Query = @"SELECT TestID FROM Tests WHERE TestAppointmentID = @TestAppointmentID";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    Connection.Open();

                    object Result = Command.ExecuteScalar();

                    if (Result != null) TestID = Convert.ToInt32(Result);
                }
            }

            return TestID;
        }

    }
}
