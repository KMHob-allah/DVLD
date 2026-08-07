using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Data
{
    static public class clDriverData
    {
        static public DataTable LoadDriversList()
        {
            string Query = @"SELECT * FROM Drivers_View";

            DataTable dtDriversList = new DataTable();

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtDriversList.Load(Reader);
                }
            }

            return dtDriversList;
        }

        static public bool LoadDriverByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreationDate)
         {          
            bool IsFound = false;

            string Query = @"SELECT * FROM Driver WHERE DriverID = @DriverID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", DriverID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            CreationDate = (DateTime)Reader["CreatedDate"];
                            PersonID = Convert.ToInt32(Reader["PersonID"]);
                            CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
            }
        static public bool LoadDriverByPersonID(ref int DriverID, int PersonID, ref int CreatedByUserID, ref DateTime CreationDate)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Drivers WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            CreationDate = (DateTime)Reader["CreatedDate"];
                            DriverID = Convert.ToInt32(Reader["DriverID"]);
                            CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }

        static public int AddDriver(int PersonID, int CreatedByUserID)
        {
            int DriverID = -1;

            string Query = @"INSERT INTO Drivers (PersonID, CreatedByUserID,CreatedDate) VALUES (@PersonID,@CreatedByUserID,@CreationDate);
                            SELECT SCOPE_IDENTITY()";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                Command.Parameters.AddWithValue("@CreationDate", DateTime.Now);

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null) DriverID = Convert.ToInt32(Result);

            }

            return DriverID;
        }
        static public bool UpdateDriverInfo(int DriverID, int PersonID, int CreatedByUserID)
        {
            int RowsAffected = 0;

            string Query = @"Update Drivers 
                            Set PersonID = @PersonID, CreatedByUserID = @CreatedByUserID
                            WHERE DriverID = @DriverID;";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@DriverID", DriverID);
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }

            return RowsAffected > 0;
        }

    }
}
