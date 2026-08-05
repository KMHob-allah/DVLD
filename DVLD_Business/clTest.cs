using DVLD_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clTest
    {
        public enum eMode { Add, Update, }
        public int ID { get; set; }
        public int AppointmentID { get; set; }
        public bool Result { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        eMode _Mode;
        public clTestAppointment AppointmentInfo { get; set; }
        public clUser UserInfo { get; set; }

        clTest()
        {
            this.ID = -1;
            this.AppointmentID = -1;
            this.Result = false;
            this.Notes = string.Empty;
            this.CreatedByUserID = -1;

            _Mode = eMode.Add;
        }
        clTest(int ID, int AppointmentID, bool Result, string Notes, int CreatedByUserID)
        {
            ID = ID;
            AppointmentID = AppointmentID;
            Result = Result;
            Notes = Notes;
            CreatedByUserID = CreatedByUserID;

            AppointmentInfo = clTestAppointment.Find(AppointmentID;
            UserInfo = clUser.Find(CreatedByUserID);

            _Mode = eMode.Update;
        }


        static public DataTable GetAllTests()
        {
            return clTestData.LoadAllTests();
        }

        static public clTest Find(int TestID)
        {
            int AppointmentID = -1;
            bool Result = false;
            string Notes = string.Empty;
            int CreatedByUserID = -1;

            if (clTestData.Find(TestID, ref AppointmentID, ref Result, ref Notes, ref CreatedByUserID))
            {
                return new clTest(TestID, AppointmentID, Result, Notes, CreatedByUserID);
            }
            else return null;
        }
        static public clTest FindForPerson(int PersonID, clTestType.eTestType TestTypeID, int LicenseClassID)
        {
            int TestID = -1;
            int AppointmentID = -1;
            bool Result = false;
            string Notes = string.Empty;
            int CreatedByUserID = -1;

            if (clTestData.LoadTestForPerson(PersonID, TestTypeID, LicenseClassID, TestID, ref AppointmentID, ref Result,
                ref Notes, ref CreatedByUserID))
            {
                return new clTest(TestID, AppointmentID, Result, Notes, CreatedByUserID);
            }
            else return null;
        }
        
        private bool _AddNewTest()
        {
            this.ID = return clTestData.AddTest(this.AppointmentID, this.Result, this.Notes, this.CreatedByUserID);

            return this.ID != -1;
        }
        private bool _UpdateTest()
        {
            return clTestData.UpdateTest(this.ID, this.AppointmentID, this.Result, this.Notes, this.CreatedByUserID);
        }

        public bool Save()
        {
            bool IsSaved = false;

            switch(_Mode)
            {
                case eMode.Add:
                {
                    if (_AddNewTest()) IsSaved = true;
                    _Mode = eMode.Update;
                    break;
                }

                case eMode.Update:
                {
                    if(_UpdateTest()) IsSaved = true;
                    break;
                }
            }

            return IsSaved;
        }

        static public int GetPassedTestCount(int LocalAppID)
        {
            return clTestData.PassedTestCount(LocalAppID);
        }
        static public bool PassedAllTests(int LocalAppID)
        {
            return GetPassedTestCount(LocalAppID) == 3;
        }
    }
}
