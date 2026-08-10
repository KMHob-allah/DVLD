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
    public class clDetainLicense
    {
        enum eMode : Byte { Add, Update};

        eMode _Mode;

        public int ID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public float FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }        

        public clUser CreatedUser { get; set; }
        public clUser ReleasedUser { get; set; }
        public clApplication ReleaseApplication { get; set; }

        public clDetainLicense ()
        {
            ID = -1;
            LicenseID = -1;
            DetainDate = DateTime.MinValue;
            FineFees = 0f;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = DateTime.MinValue;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;
            _Mode = eMode.Add;
        }
        private clDetainLicense(int ID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased, 
            DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.ID = ID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            CreatedUser = clUser.FindByUserID(CreatedByUserID);
            ReleasedUser = clUser.FindByUserID(ReleasedByUserID);
            ReleaseApplication = clApplication.Find(ReleaseApplicationID);
            _Mode = eMode.Update;
        }


        static public DataTable GetAllDetainedLicenses()
        {
            return clDetainLicenseData.LoadAllDetainedLicenses();
        }

        private bool _AddDetainLicense()
        {
            this.ID = clDetainLicenseData.AddNewDetainLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
            return this.ID != -1;
        }
        private bool _UpdateDetainedLicense()
        {
            return clDetainLicenseData.UpdateDetainedLicenseInfo(this.ID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
        }

        public bool Save()
        {
            bool IsSaved = false;

            switch (_Mode)
            {
                case eMode.Add:
                {
                    if(_AddDetainLicense())
                    {
                        IsSaved = true;
                        _Mode = eMode.Update;
                    }
                    break;
                }

                case eMode.Update:
                {
                    if (_UpdateDetainedLicense()) IsSaved = true;
                    break;
                }
            }

            return IsSaved;            
        }

        static public clLicense Find(int DetainID)
        {
            int LicenseID = -1;
            DateTime DetainDate = DateTime.MinValue;
            float FineFees = 0f;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clDetainLicenseData.LoadDetainedLicense(DetainID, ref LicenseID,  ref DetainDate, ref FineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clDetainLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
             ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            }

            else return null;
        }
        static public clDetainLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.MinValue;
            float FineFees = 0f;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clDetainLicenseData.LoadDetainedLicense(ref DetainID, LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clDetainLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
             ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            }

            else return null;
        }

        static public bool IsDetained(int LicenseID)
        {
            
            return clDetainLicenseData.IsLicenseDetained(LicenseID);
        }

        public bool Release(int ReleasedByUserID, int ReleaseApplicationID)
        {
            if (this.IsReleased) return true;

            return clDetainLicenseData.ReleaseDetainedLicense(this.ID, DateTime.Now, ReleasedByUserID, ReleaseApplicationID);
            
        }
    }

}
