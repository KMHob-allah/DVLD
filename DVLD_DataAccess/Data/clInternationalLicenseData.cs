using DVLD_DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Data
{
    static public class clInternationalLicenseData
    {

        static public DataTable LoadAllInternationalLicenses()
        {
            DataTable dtLicensesList = new DataTable();

            string Query = @"SELECT * FROM InternationalLicenses";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtLicensesList.Load(Reader);
                }
            }

            return dtLicensesList;
        }
        static public DataTable LoadAllDriverInternationalLicenses(int DriverID)
        {
            DataTable dtDriverLicensesList = new DataTable();

            string Query = @"SELECT* FROM InternationalLicenses WHERE DriverID = @DriverID";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@DriverID", DriverID);
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtDriverLicensesList.Load(Reader);
                }
            }

            return dtDriverLicensesList;
        }

        static public bool LoadInternationalLicense(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            ApplicationID = Convert.ToInt32(Reader["ApplicationID"]);
                            DriverID = Convert.ToInt32(Reader["DriverID"]);
                            IssuedUsingLocalLicenseID = Convert.ToInt32(Reader["IssuedUsingLocalLicenseID"]);
                            IssueDate = (DateTime)Reader["IssueDate"];
                            ExpirationDate = (DateTime)Reader["ExpirationDate"]; ;
                            IsActive = Convert.ToBoolean(Reader["IsActive"]);
                            CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }



        static public int AddNewInternationalLicense( int ApplicationID,  int DriverID,  int IssuedUsingLocalLicenseID,
             DateTime IssueDate,  DateTime ExpirationDate,  bool IsActive,  int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            string Query = @"
                            Update InternationalLicenses Set IsActive = 0 WHERE DriverID = @DriverID;
                            INSERT INTO 
                            InternationalLicenses 
                            (ApplicationID, DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive, CreatedByUserID)
                            VALUES 
                            (@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,@IssueDate,@ExpirationDate,@IsActive,@CreatedByUserID);
                            SELECT SCOPE_IDENTITY()";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                Command.Parameters.AddWithValue("@DriverID", DriverID);
                Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                Command.Parameters.AddWithValue("@IssueDate", IssueDate);
                Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                Command.Parameters.AddWithValue("@IsActive", IsActive);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null) InternationalLicenseID = Convert.ToInt32(Result);

            }

            return InternationalLicenseID;
        }
        static public bool UpdateInternationalLicenseInfo(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
             DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int RowsAffected = 0;

            string Query = @"Update InternationalLicenses 
                            Set
                            ApplicationID = @ApplicationID, DriverID = @DriverID, IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID
                            IssueDate = @IssueDate, ExpirationDate = @ExpirationDate,IsActive = @IsActive, CreatedByUserID = @CreatedByUserID
                            WHERE InternationalLicenseID = @InternationalLicenseID;";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
                Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                Command.Parameters.AddWithValue("@DriverID", DriverID);
                Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                Command.Parameters.AddWithValue("@IssueDate", IssueDate);
                Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                Command.Parameters.AddWithValue("@IsActive", IsActive);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }

            return RowsAffected > 0;
        }


        static public int LoadActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;

            string Query = @"SELECT InternationalLicenseID FROM InternationalLicenses WHERE DriverID = @DriverID AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", DriverID);

                    connection.Open();

                    object Result = command.ExecuteScalar();

                    if (Result != null) InternationalLicenseID = Convert.ToInt32(Result);
                }
            }

            return InternationalLicenseID;
        }

    }
}
