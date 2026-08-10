using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    static public class clDetainLicenseData
    {
        static public DataTable LoadAllDetainedLicenses()
        {
            DataTable dtLicensesList = new DataTable();

            string Query = @"SELECT * FROM DetainedLicenses_View";

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

        static public bool LoadDetainedLicense(int ID, ref int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID,
                ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM DetainedLicenses WHERE DetainID = @ID";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@ID", ID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            LicenseID = Convert.ToInt32(Reader["LicenseID"]);
                            DetainDate = (DateTime)Reader["DetainDate"];
                            FineFees = Convert.ToSingle(Reader["FineFees"]);
                            CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                            IsReleased = Convert.ToBoolean(Reader["IsReleased"]);

                            if (Reader["ReleaseDate"] == DBNull.Value) ReleaseDate = DateTime.MinValue;
                            else ReleaseDate = (DateTime)Reader["ReleaseDate"];

                            if (Reader["ReleasedByUserID"] == DBNull.Value) ReleasedByUserID = -1;
                            else ReleasedByUserID = Convert.ToInt32(Reader["ReleasedByUserID"]);

                            if (Reader["ReleaseApplicationID"] == DBNull.Value) ReleaseApplicationID = -1;
                            else ReleaseApplicationID = Convert.ToInt32(Reader["ReleaseApplicationID"]);


                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }

        static public bool LoadDetainedLicense(ref int ID, int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID,
              ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            ID = Convert.ToInt32(Reader["DetainID"]);
                            DetainDate = (DateTime)Reader["DetainDate"];
                            FineFees = Convert.ToSingle(Reader["FineFees"]);
                            CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                            IsReleased = Convert.ToBoolean(Reader["IsReleased"]);

                            if (Reader["ReleaseDate"] == DBNull.Value) ReleaseDate = DateTime.MinValue;
                            else ReleaseDate = (DateTime)Reader["ReleaseDate"];

                            if (Reader["ReleasedByUserID"] == DBNull.Value) ReleasedByUserID = -1;
                            else ReleasedByUserID = Convert.ToInt32(Reader["ReleasedByUserID"]);

                            if (Reader["ReleaseApplicationID"] == DBNull.Value) ReleaseApplicationID = -1;
                            else ReleaseApplicationID = Convert.ToInt32(Reader["ReleaseApplicationID"]);


                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }


        static public int AddNewDetainLicense(int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            int ID = -1;

            string Query = @"INSERT INTO DetainedLicenses
                           (LicenseID, DetainDate,FineFees,CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID)
                           VALUES 
                           (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID);
                           SELECT SCOPE_IDENTITY()";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                Command.Parameters.AddWithValue("@DetainDate", DetainDate);
                Command.Parameters.AddWithValue("@FineFees", FineFees);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                Command.Parameters.AddWithValue("@IsReleased", false);
                Command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                Command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);


                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null) ID = Convert.ToInt32(Result);

            }

            return ID;
        }

        static public bool UpdateDetainedLicenseInfo(int ID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            int RowsAffected = 0;

            string Query = @"Update DatainedLicenses 
                            Set
                            LicenseID = @LicenseID, DetainDate = @DetainDate, FineFees = @FineFees,CreatedByUserID = @CreatedByUserID                           
                            WHERE DetainID = @DetainID;";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@DetainID", ID);
                Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                Command.Parameters.AddWithValue("@DetainDate", DetainDate);
                Command.Parameters.AddWithValue("@FineFees", FineFees);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }

            return RowsAffected > 0;
        }

        static public bool ReleaseDetainedLicense(int DetainID, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsAffected = 0;

            string Query = @"Update DatainedLicenses 
                            Set
                            IsReleased = 1, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID                  
                            WHERE DetainID = @DetainID;";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@DetainID", DetainID);
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }

            return RowsAffected > 0;
        }

        static public bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = false;

            string Query = @"SELECT 1 FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    connection.Open();
                    object Result = command.ExecuteScalar();

                    if (Result != null) IsDetained = Convert.ToBoolean(Result);
                }
            }

            return IsDetained;
        }
    }
}
