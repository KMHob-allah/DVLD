using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clTestTypeData
    {
        static public DataTable LoadAllTestTypes()
        {
            string Query = @"SELECT * FROM TestTypes";

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
        static public bool LoadTestType(byte TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref float TestFees)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            TestTypeTitle = (Reader["TestTypeTitle"]).ToString();
                            TestTypeDescription = (Reader["TestTypeDescription"]).ToString();
                            TestFees = Convert.ToSingle(Reader["TestTypeFees"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
        static public bool UpdateTestType(byte TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestFees)
        {
            string Query = @"Update TestTypes 
                            Set TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription, TestTypeFees = @TestFees
                             WHERE TestTypeID = @TestTypeID;";

            int RowsAffected = 0;

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                Command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                Command.Parameters.AddWithValue("@TestFees", TestFees);

                Connection.Open();
                RowsAffected = Convert.ToInt32(Command.ExecuteNonQuery());

            }

            return RowsAffected > 0;
        }
    }
}
