using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clLocalApplication : clApplication
    {
        public enum eSaveResult {Success, FaildHasActiveApp, FaildHasActiveLicense, FaildLessThanMinAge, Faild}
        public enum eMode { Add, Update}

        eMode _Mode;

        public int LocalApplicationID { get; set; }
        public int LicenseClassID { get; set; }    
        
        public clLicenseClass LicenseClassInfo { get; set; }

        public clLocalApplication()
        {
            LocalApplicationID = -1;
            LicenseClassID = -1;

            _Mode = eMode.Add;
        }
        private clLocalApplication(int LocalApplicationID, int LicenseClassID, int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
           clApplicationType.eApplicationType ApplicationType, eApplicationStatus ApplicationStatus, DateTime LastStatusDate,
           float PaidFees, int CreatedByUserID) 
            
            : base(ApplicationID, ApplicantPersonID, ApplicationDate,
            ApplicationType,  ApplicationStatus, LastStatusDate,
            PaidFees, CreatedByUserID)
        {
            this.LocalApplicationID = LocalApplicationID;
            this.LicenseClassID = LicenseClassID;

            LicenseClassInfo = clLicenseClass.Find(this.LicenseClassID);

            _Mode = eMode.Update;
        }

        static public DataTable GetAllLocalAppsList()
        {
            return clLocalApplicationData.LoadLocalAppsList();
        }

        private bool _AddNewLocalApp()
        {
            this.LocalApplicationID = clLocalApplicationData.AddNewLocalApp(this.ApplicationID, this.LicenseClassID);

            return this.LocalApplicationID != -1;
        }
        private bool _UpdateLocalApp()
        {
            return clLocalApplicationData.UpdateLocalApp(this.LocalApplicationID, this.ApplicationID, this.LicenseClassID);          
        }
        public bool Delete()
        {
            if (clLocalApplicationData.DeleteLocalApp(this.LocalApplicationID))
            {
                if (base.Delete()) return true;

                else return false;
            }

            else return false;
        }

        static public clLocalApplication FindByLocalAppID(int LocalApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClasssID = -1;           

            if (clLocalApplicationData.LoadLocalApp(LocalApplicationID, ref ApplicationID, ref LicenseClasssID))
            {
                clApplication Application = clApplication.Find(ApplicationID);

                return new clLocalApplication(LocalApplicationID, LicenseClasssID, Application.ApplicationID,
                    Application.ApplicantPersonID, Application.ApplicationDate,
                    Application.ApplicationType, Application.ApplicationStatus, Application.LastStatusDate,
                    Application.PaidFees, Application.CreatedByUserID);
            }
            
            else return null;
        }
        static public clLocalApplication FindByAppID(int ApplicationID)
        {
            int LocalApplicationID = -1;
            int LicenseClasssID = -1;

            if (clLocalApplicationData.LoadLocalApp(ref LocalApplicationID, ApplicationID, ref LicenseClasssID))
            {
                clApplication Application = clApplication.Find(ApplicationID);

                return new clLocalApplication(LocalApplicationID, LicenseClasssID, Application.ApplicationID,
                    Application.ApplicantPersonID, Application.ApplicationDate,
                    Application.ApplicationType, Application.ApplicationStatus, Application.LastStatusDate,
                    Application.PaidFees, Application.CreatedByUserID);
            }

            else return null;
        }

        public eSaveResult Save()
        {
            eSaveResult SaveResult = eSaveResult.Faild;
            
            if(clLicense.IsLicenseExist(this.ApplicantPersonID, LicenseClassID))
            {
                SaveResult = eSaveResult.FaildHasActiveLicense;
                return SaveResult;
            }

            if(clLocalApplication.PersonHasActiveAppForLicenseClass(this.ApplicantPersonID, this.ApplicationType, this.LicenseClassID))
            {
                SaveResult = eSaveResult.FaildHasActiveApp;
                return SaveResult;
            }

            if(!clLocalApplication.HasLegalDrivingAge(this.ApplicantPersonID, this.LicenseClassID))
            {
                SaveResult = eSaveResult.FaildLessThanMinAge;
                return SaveResult;
            }

            if(base.Save())
            {
                switch(_Mode)
                {
                    case eMode.Add:
                    {
                        if (_AddNewLocalApp())
                        {                               
                            _Mode = eMode.Update;
                            SaveResult = eSaveResult.Success;
                        }
                        break;
                    }

                    case eMode.Update:
                    {
                        if(_UpdateLocalApp()) SaveResult = eSaveResult.Success;
                        break;
                    }
                }
            }

            return SaveResult;
        }
    }
}
