using DVLD_DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    static public class clLicenseData
    {
        static public DataTable LoadAllLicenses()
        {
            DataTable dtLicensesList = new DataTable();

            string Query = @"SELECT * FROM Licenses";

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

        static public DataTable LoadDriverLicenses(int DriverID)
        {
            DataTable dtDriverLicensesList = new DataTable();

            string Query = @"SELECT * FROM Licenses WHERE DriverID = @DriverID";

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@DriverID", DriverID);
                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    dtDriverLicensesList.Load(Reader);
                }
            }

            return dtDriverLicensesList;
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

        static public int LoadActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            int LicenseID = -1;

            string Query = @"SELECT L.LicenseID FROM Licenses L 
                            INNER JOIN Drivers D ON D.DriverID = L.DriverID
                            WHERE D.PersonID = @PersonID AND L.LicenseClassID = @LicenseClassID AND L.IsActive = 1";                          

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    connection.Open();
                    
                    object Result = command.ExecuteScalar();

                    if(Result != null) LicenseID = Convert.ToInt32(Result);                    
                }
            }

            return LicenseID;
        }

        static public bool DeactivateLicense(int LicenseID)
        {
            int RowsAffected = 0;

            string Query = @"UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @LicenseID";

            using (SqlConnection connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    connection.Open();  

                    RowsAffected = command.ExecuteNonQuery();                    
                }
            }

            return RowsAffected > 0;
        }

        static public clLegalAgeInfo GetPersonBirthDateAndMinAllowdAgeForLicenseClass(int PersonID, int LicenseClassID)
        {
            string Query = @"SELECT P.BirthDate, LC.MinimunAllowedAge 
                             From People P, LicenseClasses LC 
                             WHERE P.PersonID = @PersonID AND LC.LicenseClassID = @LicenseClassID";
                      
            clLegalAgeInfo LegalAgeInfo = null;

            using (SqlConnection Connection = new SqlConnection(DVLD_DataAccess.clSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@PersonID", PersonID);
                    Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    Connection.Open();

                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        LegalAgeInfo = new clLegalAgeInfo();

                        LegalAgeInfo.BirthDate = (DateTime)Reader["BirthDate"];
                        LegalAgeInfo.MinimumAllowedAge = (int)Reader["MinimumAllowedAge"];

                    }
                }
            }

            return LegalAgeInfo;
        }

        // Add New License Did Not Added Yet

        // Update License Did Not Added Yet
    }
}
