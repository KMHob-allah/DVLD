using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clTestType
    {
        public enum eTestType { Vision = 1, Written, Street}
        public eTestType ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }

        public clTestType()
        {
            this.ID = eTestType.Vision;
            this.Title = string.Empty;
            this.Description = string.Empty;
            this.Fees = 0f;
        }
        private clTestType(eTestType ID, string Title, string Description, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
        }

        static public DataTable GetAllTestTypes()
        {
            return clTestTypeData.LoadAllTestTypes();
        }
        static public clTestType Find(eTestType ID)
        {
            string Title = string.Empty;
            string Description = string.Empty;
            float  Fees = 0f;

            if (clTestTypeData.LoadTestType((int)ID, ref Title, ref Description, ref Fees))
            {
                return new clTestType(ID, Title, Description, Fees);
            }

            else return null;
        }

        public bool UpdateTestInfo()
        {
            return clTestTypeData.UpdateTestType((int)this.ID, this.Title, this.Description, this.Fees);
        }
    }
}
