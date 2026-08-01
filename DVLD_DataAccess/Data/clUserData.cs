using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clUserData
    {
        static public DataTable LoadUsers()
        {
            string Query = @"SELECT 
                            People.PersonID,
                            Users.UserID, 
                            FullName = CONCAT(FirstName , ' ' , SecondName , ' ' +  ThirdName + ' ' + LastName), 
                            Users.UserName,
                            Users.IsActive
                            FROM Users 
                            INNER JOIN People ON People.PersonID = Users.PersonID";

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


        static public bool LoadUserByUserID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Users Where UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            PersonID = Convert.ToInt32(Reader["PersonID"]);
                           
                            UserName = Reader["UserName"].ToString();
                            Password = Reader["Password"].ToString();

                            IsActive = Convert.ToBoolean(Reader["IsActive"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
        static public bool LoadUserByUserName(ref int UserID, ref int PersonID, string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Users Where Users.UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            PersonID = Convert.ToInt32(Reader["PersonID"]);
                            UserID   = Convert.ToInt32(Reader["UserID"]);
                            
                            Password = Reader["Password"].ToString();

                            IsActive = Convert.ToBoolean(Reader["IsActive"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }        
        static public bool LoadUserByPersonID(ref int UserID, int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Users Where PersonID = @PersonID";

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
                            UserID = Convert.ToInt32(Reader["UserID"]);
                            UserName = Reader["UserName"].ToString();

                            Password = Reader["Password"].ToString();

                            IsActive = Convert.ToBoolean(Reader["IsActive"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
        static public bool LoadUserByUserNameAndPassword(ref int UserID, ref int PersonID, string UserName, string Password, ref bool IsActive)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Users Where UserName = @UserName AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            PersonID = Convert.ToInt32(Reader["PersonID"]);
                            UserID   = Convert.ToInt32(Reader["UserID"]);

                            IsActive = Convert.ToBoolean(Reader["IsActive"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }

        static public bool IsExistByUserID(int UserID)
        {
            object Result = null;
            string Query = "SELECT 1 FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    connection.Open();
                    Result = command.ExecuteScalar();
                }
            }

            return Result != null;
        }
        static public bool IsExistByUserName(string UserName)
        {
            object Result = null;
            string Query = "SELECT 1 FROM Users WHERE UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    connection.Open();
                    Result = command.ExecuteScalar();
                }
            }

            return Result != null;
        }
        static public bool IsExistByPersonID(int PersonID)
        {
            object Result = null;
            string Query = "SELECT 1 FROM Users WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    connection.Open();
                    Result = command.ExecuteScalar();
                }
            }

            return Result != null;
        }

        static public int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int _UserID;

            string Query = @"INSERT INTO Users 
                           (PersonID, UserName, Password, IsActive)
                           VALUES
                           (@PersonID,@UserName,@Password, @IsActive);
                            
                           SELECT SCOPE_IDENTITY()";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                Command.Parameters.AddWithValue("@UserName", UserName);
                Command.Parameters.AddWithValue("@Password", Password);
                Command.Parameters.AddWithValue("@IsActive", IsActive);

                Connection.Open();
                _UserID = Convert.ToInt32(Command.ExecuteScalar());

            }

            return _UserID;
        }
        static public bool UpdateUserInfo(int UserID, string UserName, string Password, bool IsActive)
        {
            string Query = @"Update Users 
                            Set UserName = @UserName, Password = @Password , IsActive = @IsActive
                             WHERE UserID = @UserID;";

            int RowsAffected = 0;

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@UserID", UserID);
                Command.Parameters.AddWithValue("@UserName", UserName);
                Command.Parameters.AddWithValue("@Password", Password);
                Command.Parameters.AddWithValue("@IsActive", IsActive);

                Connection.Open();
                RowsAffected = Convert.ToInt32(Command.ExecuteNonQuery());

            }

            return RowsAffected > 0;
        }

        static public bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;
            string Query = "DELETE FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    connection.Open();
                    RowsAffected = command.ExecuteNonQuery();
                }
            }

            return RowsAffected > 0;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int RowsAffected = 0;

            string Query = @"UPDATE  Users  SET Password = @Password WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(clSettings.ConnectionString))
            { 
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);                        
                    command.Parameters.AddWithValue("@Password", NewPassword);                        
                    connection.Open();
                    RowsAffected = command.ExecuteNonQuery();                        
                }
            }

            return (RowsAffected > 0);
        }
    }
}
