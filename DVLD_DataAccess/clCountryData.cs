using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clCountryData
    {
        static public DataTable LoadAllCountries()
        {
            DataTable dtCountriesList = new DataTable();

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Countries", Connection))
                {
                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        dtCountriesList.Load(Reader);
                    }

                }
            }

            return dtCountriesList;
        }        
        static public bool LoadCountry(int CountryID, ref string CountryName)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM Countries Where CountryID = @CountryID";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@CountryID", CountryID);

                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();
                                      
                   if(Reader.Read()) 
                    {
                        CountryName = Reader["CountryName"].ToString();
                        IsFound = true;
                    }    
                }
            }

            return IsFound;
        }
        static public bool LoadCountry(ref int CountryID, string CountryName)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM Countries Where CountryName = @CountryName";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@CountryName", CountryName);

                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        CountryID = Convert.ToInt32(Reader["CountryID"]);
                        IsFound = true;
                    }
                }
            }

            return IsFound;
        }
    }
}
