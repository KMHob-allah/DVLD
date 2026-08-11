using DVLD_DataAccess;
using DVLD_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clDriver
    {
        public enum eMode { Add, Update}

        public int ID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreationDate { get;}

        public clPerson PersonInfo { get; set; }
        public clUser UserInfo {  get; set; }

        eMode _Mode;


        public clDriver()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreationDate = DateTime.MinValue;

            _Mode = eMode.Add;
        }
        private clDriver(int ID, int PersonID, int CreatedByUserID, DateTime CreationDate)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreationDate = CreationDate;

            _Mode = eMode.Update;

            this.PersonInfo = clPerson.Find(PersonID);
            this.UserInfo = clUser.FindByUserID(CreatedByUserID);
        }

        static public DataTable GetAllDrivers()
        {
            return clDriverData.LoadDriversList();
        }

        static public DataTable GetLocalLicenses(int DriverID)
        {
            return clLicenseData.LoadDriverLocalLicenses(DriverID);
        }
        static public DataTable GetInternationalLicenses(int DriverID)
        {
            
            return clInternationalLicenseData.LoadAllDriverInternationalLicenses(DriverID);
        }

        static public clDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreationDate = DateTime.MinValue;

            if (clDriverData.LoadDriverByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreationDate))
            {
                return new clDriver(DriverID, PersonID, CreatedByUserID, CreationDate);

            }

            else return null;
        }
        static public clDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreationDate = DateTime.MinValue;

            if (clDriverData.LoadDriverByPersonID(ref DriverID, PersonID, ref CreatedByUserID, ref CreationDate))
            {
                return new clDriver(DriverID, PersonID, CreatedByUserID, CreationDate);

            }

            else return null;
        }
        bool _AddNewDriver()
        {
            this.ID =  clDriverData.AddDriver(this.PersonID, this.CreatedByUserID);
            
            return this.ID != -1;
        }
        bool _UpdateDriver()
        {
            return clDriverData.UpdateDriverInfo(this.ID, this.PersonID, this.CreatedByUserID);

        }

        public bool Save()
        {
            bool IsSaved = false;

            switch (_Mode)
            {
                case eMode.Add:{
                    if(_AddNewDriver())
                    {
                        IsSaved = true;
                        _Mode = eMode.Update;
                    }
                    break;
                }

                case eMode.Update:
                {
                    if (_UpdateDriver()) IsSaved = true;
                    break;
                }
            }
            
            return IsSaved;
        }

        
    }
}
