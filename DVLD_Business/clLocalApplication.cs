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
        // What should I do : Creating new enum for this class Or Using the same base's enum And What is the difference ?

        public int LocalApplicationID { get; set; }
        public int LicenseClassID { get; set; }    
            

        public clLocalApplication()
        {
            LocalApplicationID = -1;
            LicenseClassID = -1;

            this.Mode = eMode.Add;
        }
        private clLocalApplication(int LocalApplicationID, int LicenseClassID, int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
           eApplicationType ApplicationType, eApplicationStatus ApplicationStatus, DateTime LastStatusDate,
           float PaidFees, int CreatedByUserID) 
            
            : base(ApplicationID, ApplicantPersonID, ApplicationDate,
            ApplicationType,  ApplicationStatus, LastStatusDate,
            PaidFees, CreatedByUserID)
        {
            this.LocalApplicationID = LocalApplicationID;
            this.LicenseClassID = LicenseClassID;

            this.Mode = eMode.Update;
        }

        static public DataTable GetAllLocalAppsList()
        {
            return clLocalApplicationData.LoadLocalAppsList():
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
            bool IsDeleted = false;

            if(clLocalApplicationData.DeleteLocalApp(this.LocalApplicationID)) if (base.Delete()) return true;            

            return IsDeleted;            
        }

        static public clLocalApplication FindByLocalAppID(int LocalApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClasssID = -1;           

            if (clLocalApplicationData.LoadLocalApp(LocalApplicationID, ref ApplicationID, ref LicenseClasssID))
            {
                clLocalApplication Application = clApplication.Find(ApplicationID);

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
                clLocalApplication Application = clApplication.Find(ApplicationID);

                return new clLocalApplication(LocalApplicationID, LicenseClasssID, Application.ApplicationID,
                    Application.ApplicantPersonID, Application.ApplicationDate,
                    Application.ApplicationType, Application.ApplicationStatus, Application.LastStatusDate,
                    Application.PaidFees, Application.CreatedByUserID);
            }

            else return null;
        }

        public bool Save()
        {
            eMode CurrentMode = Mode;

            bool IsSaved = false;

            if(base.Save())
            {
                switch(CurrentMode)
                {
                    case eMode.Add:
                    {
                        if (_AddNewLocalApp())
                        {
                               
                            CurrentMode = eMode.Update;
                            IsSaved = true;
                        }
                        break;
                    }

                    case eMode.Update:
                    {
                        if(_UpdateLocalApp()) IsSaved  = true;
                        break;
                    }
                }
            }

            return IsSaved;
        }

    }
}
