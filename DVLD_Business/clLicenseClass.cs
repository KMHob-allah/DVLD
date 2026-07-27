using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clLicenseClass
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public short MinAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; }
        public float ClassFees { get; set; }

        public clLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = string.Empty;
            this.ClassDescription = string.Empty;
            this.MinAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0f;
        }
        private clLicenseClass(int LicenseClassID, string ClassName, string ClassDescription,
            short MinAllowedAge, short DefaultValidityLength, float ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinAllowedAge = MinAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        static public DataTable GetAllLicenseClasses()
        {
            return DVLD_DataAccess.clLicenseClass.LoadLicenseClasses();
        }

        static public clLicenseClass Find(int LicenseClassID)
        {
            string ClassName = string.Empty;
            string ClassDescription = string.Empty;
            short MinAllowedAge = 0;
            short DefaultValidityLength = 0;
            float ClassFees = 0f;

            if (clLicenseClassData.LoadLicenseClass(LicenseClassID, ref ClassName, ref ClassDescription, ref MinAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clLicenseClass(LicenseClassID, ClassName, ClassDescription, MinAllowedAge, DefaultValidityLength, ClassFees);
            }

            else return null;
        }
    }
}
