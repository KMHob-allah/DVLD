using DVLD_DataAccess;
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


        public clApplication ApplicationInfo { get; set; }
        //public clDriver DriverInfo { get; set; }
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
            //this.DriverInfo = clDriver.Find(DriverID);
            this.LicenseClassInfo = clLicenseClass.Find(LicenseClassID);
            this.UserInfo = clUser.FindByUserID(CreatedByUserID);
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
    }
}
