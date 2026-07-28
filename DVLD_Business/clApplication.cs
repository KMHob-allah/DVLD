using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clApplication
    {
        public enum eMode { Add, Update}       
        public enum eApplicationStatus
        {
            New = 1,
            Canceled,
            Completed
        }

        private eMode Mode;

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public clApplicationType.eApplicationType ApplicationType { get; set; }
        public eApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clPerson PersonInfo { get; set; }
        public clUser UserInfo { get; set; }
        public clApplicationType ApplicationTypeInfo { get; set; }


        public clApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.MinValue;
            ApplicationType = clApplicationType .eApplicationType.Unknown;
            ApplicationStatus = eApplicationStatus.New;
            LastStatusDate = DateTime.MinValue;
            PaidFees = 0f;
            CreatedByUserID = -1;

            Mode = eMode.Add;
        }
        protected clApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
           clApplicationType.eApplicationType ApplicationType, eApplicationStatus ApplicationStatus, DateTime LastStatusDate,
           float PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationType = ApplicationType;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            this.PersonInfo = clPerson.Find(ApplicantPersonID);
            this.UserInfo = clUser.FindByUserID(CreatedByUserID);
            this.ApplicationTypeInfo = clApplicationType.Find(ApplicationType);

            Mode = eMode.Update;
        }
 
        static public DataTable GetAllAppList()
        {
            return clApplicationData.LoadAllApplications();
        }

        static public clApplication Find(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            byte ApplicationType = 1;
            byte ApplicationStatus = 1;
            DateTime LastStatusDate = DateTime.MinValue;
            float PaidFees = 0f;
            int CreatedByUserID = -1;

            if(clApplicationData.LoadApplication(ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
                ref ApplicationType, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
                (clApplicationType.eApplicationType)ApplicationType, (eApplicationStatus)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }

            else return null;
        }

        private bool _AddNewApp()
        {
            this.ApplicationID = clApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate,
                (byte)this.ApplicationType, (byte) this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return this.ApplicationID != -1;
        }
        private bool _UpdateApp()
        {
            return clApplicationData.UpdateApplication(this.ApplicationID,this.ApplicantPersonID, this.ApplicationDate,
               (byte)this.ApplicationType, (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

        }

        public bool Save()
        {
            bool IsSaved = false;

           switch(Mode)
            {
                case eMode.Add:
                {
                    if(_AddNewApp())
                    {
                        Mode = eMode.Update;
                        IsSaved = true;
                    }

                    break;
                }

                case eMode.Update:
                {
                    if (_UpdateApp()) IsSaved = true;

                    break;
                }
            }

            return IsSaved;
        }

        private bool _UpdateAppStatus(eApplicationStatus NewStatus)
        {
            return clApplicationData.UpdateAppStatus(this.ApplicationID, (byte)NewStatus);
        }

        public bool Cancel()
        {
            return _UpdateAppStatus(eApplicationStatus.Canceled);
        }
        public bool SetComplete()
        {
            return _UpdateAppStatus(eApplicationStatus.Completed);
        }

        public bool Delete()
        {
            return clApplicationData.DeleteApplication(this.ApplicationID);
        }

        static public bool IsExist(int ApplicationID)
        {
            return clApplicationData.IsApplicationExist(ApplicationID);
        }

        static public bool PersonHasActiveApp(int ApplicantPersonID, clApplicationType. eApplicationType ApplicationTypeID)
        {
            return clApplicationData.PersonHasActiveApp(ApplicantPersonID, (byte)ApplicationTypeID);
        }
        static public bool PersonHasActiveAppForLicenseClass(int ApplicationPersonID, clApplicationType.eApplicationType ApplicationTypeID, int LicenseClass)
        {
            return clApplicationData.PersonHasActiveAppForLicenseClass(ApplicationPersonID, (byte)ApplicationTypeID, LicenseClass);
        }


    }
}
