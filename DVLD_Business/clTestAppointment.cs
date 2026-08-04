using DVLD_DataAccess;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clTestAppointment
    {
        public enum eMode : byte { Add, Update }

        eMode _Mode;
        public int AppointmentID { get; set; }
        public clTestType.eTestType TestType { get; set; }
        public int LocalAppID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestAppID { get; set; }

        public clLocalApplication LocalApplicationInfo { get; set; }
        public clApplication ApplicationInfo { get; set; }
        public clUser UserInfo { get; set; }

        public clTestAppointment()
        {
            this.AppointmentID = -1;
            this.TestType = clTestType.eTestType.Vision;
            this.LocalAppID = -1;
            this.AppointmentDate = DateTime.MinValue;
            this.PaidFees = 0f;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestAppID = -1;

            _Mode= eMode.Add;
        }
        private clTestAppointment(int TestAppointmentID, clTestType.eTestType TestType, int LocalAppID, DateTime AppointmentDate, 
            float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestAppID)
        {
            this.AppointmentID = TestAppointmentID;
            this.TestType = TestType;
            this.LocalAppID = LocalAppID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestAppID = RetakeTestAppID;
            _Mode = eMode.Update;

            LocalApplicationInfo = clLocalApplication.FindByLocalAppID(LocalAppID);
            ApplicationInfo = clApplication.Find(this.RetakeTestAppID);
            UserInfo = clUser.FindByUserID(CreatedByUserID);
        }

        public int TestID
        {
            get
            {
               return clTestAppointmentData.LoadTestID(this.AppointmentID);
            }
        }

        static public DataTable GetAppointmentsListForLocalApp(int LocalAppID, int TestTypeID)
        {
            return clTestAppointmentData.LoadAllAppointmentsListForLocalApp(LocalAppID, TestTypeID);
        }

        static public DataTable GetAllAppointmentsList()
        {
            return clTestAppointmentData.LoadAllAppointmentsList();
        }
        private bool _AddNewAppointment()
        {
            this.AppointmentID = clTestAppointmentData.AddNew((int)this.TestType, this.LocalAppID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestAppID);

            return this.AppointmentID != -1;
        }
        private bool _UpdateAppointment()
        {
            return clTestAppointmentData.Update(this.AppointmentID, (int)this.TestType,
                this.LocalAppID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestAppID);
        }

        public bool Save()
        {
            bool IsSaved = false;

            switch(_Mode)
            {
                case eMode.Add:
                {
                    if(_AddNewAppointment())
                    {
                        _Mode = eMode.Update;
                        IsSaved = true;
                    }
                        break;
                }

                case eMode.Update:
                {
                    if (_UpdateAppointment()) IsSaved = true;
                    break;
                }
            }

            return IsSaved;
        }

        static public clTestAppointment Find(int AppointmentID)
        {
            int TestType = -1;
            int LocalAppID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            float PaidFees = 0f;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestAppID = -1;

            if (clTestAppointmentData.LoadTestAppointment(AppointmentID, ref TestType, ref LocalAppID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppID))
            {
                return new clTestAppointment(AppointmentID, (clTestType.eTestType)TestType, LocalAppID,
                 AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppID);
            }
            else return null;
        }

        static public clTestAppointment FindLastTestAppointment(int LocalAppID, int TestType)
        {
            int AppointmentID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            float PaidFees = 0f;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestAppID = -1;

            if (clTestAppointmentData.LoadTestAppointment(AppointmentID, ref TestType, ref LocalAppID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppID))
            {
                return new clTestAppointment(AppointmentID, (clTestType.eTestType)TestType, LocalAppID,
                 AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppID);
            }

            else return null;
        }

    }
}
