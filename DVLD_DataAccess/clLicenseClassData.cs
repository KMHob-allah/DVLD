using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clLicenseClassData
    {

        static public DataTable LoadAllLicenseClassesList()
        {
            string Query = @"SELECT LicenseClassID, ClassName FROM LicenseClasses";

            DataTable dtClassesList = new DataTable();

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtClassesList.Load(Reader);
                }
            }

            return dtClassesList;
        }

        static public bool LoadLicenseClass(int LicenseClassID, ref string ClassName, ref string ClassDescription,
            ref short MinAllowedAge, ref short DefaultValidityLength, ref float ClassFees)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    connection.Open();

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            ClassName = Reader["ClassName"].ToString();
                            ClassDescription = Reader["ClassDescription"].ToString();

                            MinAllowedAge = Convert.ToInt16(Reader["MinimumAllowedAge"]);
                            DefaultValidityLength = Convert.ToInt16(Reader["DefaultValidityLength"]);

                            ClassFees = Convert.ToSingle(Reader["ClassFees"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }
       
    }
}
