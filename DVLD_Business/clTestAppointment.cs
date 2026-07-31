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
        public enum eMode { Add, Update, }

        eMode _Mode;
        public int AppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalAppID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int? RetakeTestAppID { get; set; }

        public clLocalApplication LocalApplicationInfo { get; set; }        
        public clUser UserInfo { get; set; }

        public clTestAppointment()
        {
            this.AppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalAppID = -1;
            this.AppointmentDate = DateTime.MinValue;
            this.PaidFees = 0f;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestAppID = null;

            _Mode= eMode.Add;
        }
        private clTestAppointment(int TestAppointmentID, int TestTypeID, int LocalAppID, DateTime AppointmentDate, 
            float PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestAppID)
        {
            this.AppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalAppID = LocalAppID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestAppID = RetakeTestAppID;
            _Mode = eMode.Update;

            LocalApplicationInfo = clLocalApplication.FindByLocalAppID(LocalAppID);
            UserInfo = clUser.FindByUserID(CreatedByUserID);
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
            this.AppointmentID = clTestAppointmentData.AddNew(this.TestTypeID, this.LocalAppID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestAppID);

            return this.AppointmentID != -1;
        }
        private bool _UpdateAppointment()
        {
            return clTestAppointmentData.Update(this.AppointmentID, this.TestTypeID,
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
            int TestTypeID = -1;
            int LocalAppID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            float PaidFees = 0f;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int? RetakeTestAppID = null;

            if (clTestAppointmentData.LoadTestAppointment(AppointmentID, ref TestTypeID, ref LocalAppID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppID))
            {
                return new clTestAppointment(AppointmentID, TestTypeID, LocalAppID,
                 AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppID);
            }
            else return null;
        }
    }
}
