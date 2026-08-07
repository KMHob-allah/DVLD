using DVLD_DataAccess;
using DVLD_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clLicense
    {
        public enum eMode { Add, Update}
        public enum eIssueReason : byte { FirstTime = 1, Renew, ReplacementForDamaged, ReplacementForLost, Unknown }

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public eIssueReason IssueReason { get; set; }      
        public int CreatedByUserID { get; set; }

        eMode _Mode;

        public clApplication ApplicationInfo { get; set; }
        public clDriver DriverInfo { get; set; }
        public clLicenseClass LicenseClassInfo { get; set; }
        public clUser UserInfo { get; set; }


        public clLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.Notes = string.Empty;
            this.PaidFees = 0f;
            this.IsActive = false;
            this.IssueReason = eIssueReason.Unknown;
            this.CreatedByUserID = -1;

            _Mode = eMode.Add;
        }
        private clLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate,
            string Notes, float PaidFees, bool IsActive, eIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            this.ApplicationInfo = clApplication.Find(ApplicationID);
            this.DriverInfo = clDriver.FindByDriverID(DriverID);
            this.LicenseClassInfo = clLicenseClass.Find(LicenseClassID);
            this.UserInfo = clUser.FindByUserID(CreatedByUserID);

            _Mode = eMode.Update;
        }


        static public clLicense Find(int LicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = string.Empty;
            float PaidFees = 0f;
            bool IsActive = false;
            sbyte IssueReason = -1;
            int CreatedByUserID = -1;

            if (clLicenseData.LoadLicense(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate,
             ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate,
                Notes, PaidFees, IsActive, (eIssueReason)IssueReason, CreatedByUserID);
            }

            else return null;
        }

        static public bool IsLicenseExist(int PersonID, int LicenseClassID)
        {
            return clLicenseData.IsLicenseExist(PersonID, LicenseClassID);
        }


        bool _AddNewLicense()
        {
            this.LicenseID = clLicenseData.AddNewLicense(this.ApplicationID, this. DriverID, this. LicenseClassID, this. IssueDate, this. ExpirationDate,
            this. Notes, this. PaidFees, this. IsActive, (int)this. IssueReason, this. CreatedByUserID);

            return this.LicenseID != -1;
        }
        bool _UpdateLicense()
        {
            return clLicenseData.UpdateLicenseInfo(this. LicenseID, this. ApplicationID, this. DriverID, this. LicenseClassID, this. IssueDate, this. ExpirationDate,
            this. Notes, this. PaidFees, this. IsActive, (int)this. IssueReason, this. CreatedByUserID);

        }

        public bool Save()
        {
            bool IsSaved = false;

            switch (_Mode)
            {
                case eMode.Add:
                    {
                        if (_AddNewLicense())
                        {
                            IsSaved = true;
                            _Mode = eMode.Update;
                        }
                        break;
                    }

                case eMode.Update:
                    {
                        if (_UpdateLicense()) IsSaved = true;
                        break;
                    }
            }

            return IsSaved;
        }

        static public bool IsLicenseExistForPerson(int PersonID, int LicenseClassID)
        {
            return GetActiveLicenseForPerson(PersonID, LicenseClassID) != -1;
        }
        static public int GetActiveLicenseForPerson(int PersonID, int LicenseClassID)
        {
            return clLicenseData.LoadActiveLicenseIDByPersonID(PersonID, LicenseClassID);
        }

        public bool IsExpired()
        {
            return this.ExpirationDate < DateTime.Now;
        }

        public bool Deactivate()
        {
            return clLicenseData.DeactivateLicense(this.LicenseID);
        }

        static public string strIssueReason(eIssueReason IssueReason)
        {
            string strIssueReason = string.Empty;

            switch(IssueReason)
            {
                case eIssueReason.FirstTime:
                {
                    strIssueReason= "First Time";
                    break;
                }

                case eIssueReason.Renew:
                { 
                    strIssueReason= "Renew";
                    break;
                }

                case eIssueReason.ReplacementForDamaged:
                {
                    strIssueReason= "ReplacementForDamaged";
                    break;
                }

                case eIssueReason.ReplacementForLost:
                {
                    strIssueReason= "ReplacementForLost";
                    break;
                }

                case eIssueReason.Unknown:
                {
                    strIssueReason = "Unknown";
                    break;
                }
            }

            return strIssueReason;
        }
    }
}
