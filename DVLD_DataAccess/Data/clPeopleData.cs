using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    static public class clPersonData
    {
        static public bool LoadPerson(int PersonID, ref string NationalNumber, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref string Email, ref string Phone,
            ref DateTime BirthDate, ref string Address, ref string ImagePath, ref int CountryID, ref byte Gender)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM People WHERE PersonID = @PersonID";

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
                            NationalNumber = Reader["NationalNumber"].ToString();

                            FirstName = Reader["FirstName"].ToString();
                            SecondName = Reader["SecondName"].ToString();

                            // Third Name Is Nullable In The Database
                             
                            ThirdName = (Reader["ThirdName"] != DBNull.Value ? Reader["ThirdName"].ToString() : string.Empty);
                            LastName = Reader["LastName"].ToString();

                            Email = (Reader["Email"] != DBNull.Value ? Reader["Email"].ToString() : string.Empty);

                            Phone = Reader["Phone"].ToString();
                            BirthDate = (DateTime)Reader["BirthDate"];
                            Address = Reader["Address"].ToString();

                            ImagePath = (Reader["ImagePath"] != DBNull.Value ? Reader["ImagePath"].ToString() : string.Empty);

                            CountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                            Gender = Convert.ToByte(Reader["Gender"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
        static public bool LoadPerson(ref int PersonID, string NationalNumber, ref string FirstName, ref string SecondName,
          ref string ThirdName, ref string LastName, ref string Email, ref string Phone,
          ref DateTime BirthDate, ref string Address, ref string ImagePath, ref int CountryID, ref byte Gender)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM People WHERE NationalNumber = @NationalNumber";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            PersonID = Convert.ToInt32(Reader["PersonID"]);

                            FirstName = Reader["FirstName"].ToString();
                            SecondName = Reader["SecondName"].ToString();

                            // Third Name Is Nullable In The Database
                            ThirdName = (Reader["ThirdName"] != DBNull.Value ? Reader["ThirdName"].ToString() : string.Empty);
                            LastName = Reader["LastName"].ToString();

                            Email = (Reader["Email"] != DBNull.Value ? Reader["Email"].ToString() : string.Empty);
                            Phone = Reader["Phone"].ToString();

                            BirthDate = (DateTime)Reader["BirthDate"];
                            Address = Reader["Address"].ToString();

                            ImagePath = (Reader["ImagePath"] != DBNull.Value ? Reader["ImagePath"].ToString() : string.Empty);

                            CountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                            Gender = Convert.ToByte(Reader["Gender"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
        static public int AddNewPerson(string FirstName, string SecondName, string ThirdName,
            string LastName, string NationalNumber, byte Gender, string Email, string Address, DateTime BirthDate,
           string Phone, int NationalityCountryID, string ImagePath)
        {
            int _PersonID = -1;

            string Query = @"INSERT INTO 
                            People 
                           (FirstName, SecondName,ThirdName,LastName,NationalNumber,Gender,Email,Address,BirthDate,Phone,
                            NationalityCountryID,ImagePath)
                           VALUES 
                            (@FirstName,@SecondName,@ThirdName,@LastName,@NationalNumber,@Gender,@Email,@Address,@BirthDate,
                            @Phone,@NationalitryCountryID,@ImagePath);
                            SELECT SCOPE_IDENTITY()";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@FirstName", FirstName);
                Command.Parameters.AddWithValue("@SecondName", SecondName);

                if(string.IsNullOrEmpty(ThirdName)) Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                else Command.Parameters.AddWithValue("@ThirdName", ThirdName);

                Command.Parameters.AddWithValue("@LastName", LastName);
                Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                Command.Parameters.AddWithValue("@Gender", Gender);


                if (string.IsNullOrEmpty(Email)) Command.Parameters.AddWithValue("@Email", DBNull.Value);
                else Command.Parameters.AddWithValue("@Email", Email);

                Command.Parameters.AddWithValue("@Address", Address);
                Command.Parameters.AddWithValue("@BirthDate", BirthDate);
                Command.Parameters.AddWithValue("@Phone", Phone);
                Command.Parameters.AddWithValue("@NationalitryCountryID", NationalityCountryID);


                if (string.IsNullOrEmpty(ImagePath)) Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                else Command.Parameters.AddWithValue("@ImagePath", ImagePath);

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null) _PersonID = Convert.ToInt32(Result);

            }

            return _PersonID;
        }
        static public bool UpdatePersonInfo(int PersonID, string FirstName, string SecondName, string ThirdName,
            string LastName, string NationalNumber, byte Gender, string Email, string Address, DateTime BirthDate,
           string Phone, int NationalityCountryID, string ImagePath)
        {
            int RowsAffected = 0;

            string Query = @"Update People 
                            Set
                            FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName,LastName = @LastName, 
                            NationalNumber = @NationalNumber, Gender = @Gender, Email = @Email, Address = @Address, 
                            DateOfBirth = @DateOfBirth, Phone = @Phone, NationalityCountryID = @NationalitryCountryID, ImagePath = @ImagePath
                            WHERE PersonID = @PersonID;";


            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                Command.Parameters.AddWithValue("@FirstName", FirstName);
                Command.Parameters.AddWithValue("@SecondName", SecondName);

                if (string.IsNullOrEmpty(ThirdName)) Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                else Command.Parameters.AddWithValue("@ThirdName", ThirdName);

                Command.Parameters.AddWithValue("@LastName", LastName);
                Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                Command.Parameters.AddWithValue("@Gender", Gender);

                if (string.IsNullOrEmpty(Email)) Command.Parameters.AddWithValue("@Email", DBNull.Value);
                else Command.Parameters.AddWithValue("@Email", Email);

                Command.Parameters.AddWithValue("@Address", Address);
                Command.Parameters.AddWithValue("@BirthDate", BirthDate);
                Command.Parameters.AddWithValue("@Phone", Phone);
                Command.Parameters.AddWithValue("@NationalitryCountryID", NationalityCountryID);

                if (string.IsNullOrEmpty(ImagePath)) Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                else Command.Parameters.AddWithValue("@ImagePath", ImagePath);


                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }

            return RowsAffected > 0;
        }
        static public DataTable LoadAllPeople()
        {
            DataTable dtPeopleList = new DataTable();

            string Query = @"SELECT 
                            People.PersonID,
                            People.NationalNumber,
                            People.FirstName,
                            People.SecondName, 
                            People.ThirdName,
                            People.LastName,
                            People.BirthDate, 
                            Gender = CASE WHEN People.Gender = 0 THEN 'Male' ELSE 'Female' END,
                            Countries.CountryName,
                            People.Phone, 
                            People.Email
                            FROM People 
                            INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID";


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
        static public bool DeletePerson(int PersonID)
        {
            int RowsAffected = 0;

            string Query = "DELETE FROM People WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    connection.Open();
                    RowsAffected = command.ExecuteNonQuery();
                }
            }

            return RowsAffected > 0;
        }
        static public bool IsExist(int PersonID)
        {
            object Result = null;

            string Query = "SELECT 1 FROM People WHERE PersonID = @PersonID";

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
        static public bool IsExist(string NationalNumber)
        {
            object Result = null;
            string Query = "SELECT 1 FROM People WHERE NationalNumber = @NationalNumber";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                    connection.Open();
                    Result = command.ExecuteScalar();
                }
            }

            return Result != null;
        }      
    }
}
