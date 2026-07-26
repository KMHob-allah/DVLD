using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clApplicationType
    {
        public int AppTypeID { get; set; }
        public string AppTypeTitle { get; set; }
        public float AppTypeFees { get; set; }

        public clApplicationType()
        {
            this.TypeID = -1;
            this.Title = string.Empty;
            this.Fees = 0f;
        }
        private clApplicationType(int TypeID, string Title, float Fees)
        {
            this.TypeID = TypeID;
            this.Title = Title;
            this.Fees = Fees;
        }

        static public DataTable GetAllAppTypes()
        {
            return clApplicationTypeData.LoadAllAppTypes();
        }

        static public clApplicationType Find(int ApplicationTypeID)
        {
            string Title = string.Empty;
            float Fees = 0f;

            if (clApplicationTypeData.LoadAppType(ApplicationTypeID, ref Title, ref Fees))
            {
                return new clApplicationType(ApplicationTypeID, Title, Fees);
            }

            else return null;
        }
        
        public bool UpdateTypeInfo(string NewTitle = this.AppTypeTitle, float NewFees = this.AppTypeFees)
        {
            return clApplicationTypeData.UpdateAppType(this.TypeID, NewTitle, NewFees);
        }
    }
}
