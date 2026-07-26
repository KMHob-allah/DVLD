using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    static public class clApplicationTypeData
    {
        static public DataTable LoadAllAppTypes()
        {
            string Query = @"SELECT * FROM ApplicationTypes";

            DataTable dtUsersList = new DataTable();

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtUsersList.Load(Reader);
                }
            }

            return dtUsersList;
        }
        static public bool LoadAppType(int ApplicationTypeID, ref string Title, ref float Fees)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            Title = Reader["ApplicationTypeTitle"].ToString();
                            Fees = Convert.ToSingle(Reader["ApplicationFees"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
        static public bool UpdateAppType(int TypeID, string NewTitle, float NewFees)
        {
            string Query = @"Update ApplicationTypes 
                            Set ApplicationTypeTitle = @NewTitle, ApplicationFees = @NewFees
                             WHERE ApplicationTypeID = @TypeID;";

            int RowsAffected = 0;

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@TypeID", TypeID);
                Command.Parameters.AddWithValue("@NewTitle", NewTitle);
                Command.Parameters.AddWithValue("@NewFees", NewFees);

                Connection.Open();
                RowsAffected = Convert.ToInt32(Command.ExecuteNonQuery());

            }

            return RowsAffected > 0;
        }
    }
}
