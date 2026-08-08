using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Data
{
    static public class clDetainedLicenseData
    {
        static public bool IsDetained(int LicenseID)
        {
            object Result = null;
            string Query = "SELECT 1 FROM DetainedLicenses WHERE LicenseID = @LicenseID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    connection.Open();
                    Result = command.ExecuteScalar();
                }
            }

            return Result != null;
        }
    }
}
