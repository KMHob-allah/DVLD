using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    static public class clLicenseData
    {
        static public bool LoadLicense(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID,
            ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref string Notes, ref float PaidFees, ref bool IsActive, ref sbyte IssueReason, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

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
                             ApplicationID = Convert.ToInt32(Reader["ApplicationID"]);
                             DriverID = Convert.ToInt32(Reader["DriverID"]);
                             LicenseClassID = Convert.ToInt32(Reader["LicenseClassID"]);
                             IssueDate = (DateTime)Reader["IssueDate"]; 
                             ExpirationDate = (DateTime)Reader["ExpirationDate"]; ;
                             Notes = Reader["Notes"].ToString();
                             PaidFees = Convert.ToSingle(Reader["PaidFees"]);
                             IsActive = Convert.ToBoolean(Reader["IsActive"]);
                             IssueReason = Convert.ToSByte(Reader["IssueReason"]);
                             CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);

                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;
        }

        static public bool IsLicenseExist(int PersonID, int LicenseClassID)
        {           
            object Result = null;

            string Query = @"SELECT 1 FROM Licenses  L
                            INNER JOIN Applications A On L.ApplicationID = A.ApplicationID
                            INNER JOIN People P On P.PersonID = A.ApplicantPersonID
                            Where PersonID = @PersonID AND LicenseClassID = @LicenseClassID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    connection.Open();
                    Result = command.ExecuteScalar();
                }
            }

            return Result != null;            
        }
    }
}
