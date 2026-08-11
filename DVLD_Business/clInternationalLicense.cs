using DVLD_DataAccess;
using DVLD_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_Business.clLicense;

namespace DVLD_Business
{
    public class clInternationalLicense
    {
        enum eMode { Add, Update}

        eMode _Mode;
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssueUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate  { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clUser UserInfo { get; set; }
        public clDriver DriverInfo { get; set; }
        public clApplication ApplicationInfo {  get; set; }

        public clInternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssueUsingLocalLicenseID = -1;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            IsActive  = false;
            CreatedByUserID = -1;
            _Mode = eMode.Add;
        }
        private clInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssueUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssueUsingLocalLicenseID = -1;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            IsActive = false;
            CreatedByUserID = -1;

            _Mode = eMode.Update;

            this.UserInfo = clUser.FindByUserID(CreatedByUserID);
            this.DriverInfo = clDriver.FindByDriverID(DriverID);
            this.ApplicationInfo = clApplication.Find(ApplicationID);
        }

        static public DataTable GetAllInternationalLicenses()
        {
            return clInternationalLicenseData.LoadAllInternationalLicenses();
        }
        static public DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clInternationalLicenseData.LoadDriverLocalLicenses(DriverID);
        }

        static public clInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssueUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clInternationalLicenseData.LoadInternationalLicense(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssueUsingLocalLicenseID
                , ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssueUsingLocalLicenseID, 
                    IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }

            else return null;
        }


        bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clInternationalLicenseData.AddNewInternationalLicense(this.ApplicationID, this.DriverID, 
                this.IssueUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return this.InternationalLicenseID != -1;
        }
        bool _UpdateInternationalLicense()
        {
            return clInternationalLicenseData.UpdateInternationalLicenseInfo(this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                this.IssueUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

        }

        public bool Save()
        {
            bool IsSaved = false;

            switch (_Mode)
            {
                case eMode.Add:
                    {
                        if (_AddNewInternationalLicense())
                        {
                            IsSaved = true;
                            _Mode = eMode.Update;
                        }
                        break;
                    }

                case eMode.Update:
                    {
                        if (_UpdateInternationalLicense()) IsSaved = true;
                        break;
                    }
            }

            return IsSaved;
        }     

        static public int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            return clInternationalLicenseData.LoadActiveInternationalLicenseIDByDriverID(DriverID);
        }

    }
}
