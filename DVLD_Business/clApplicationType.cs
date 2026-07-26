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
            this.AppTypeID = -1;
            this.AppTypeTitle = string.Empty;
            this.AppTypeFees = 0f;
        }
        private clApplicationType(int TypeID, string Title, float Fees)
        {
            this.AppTypeID = TypeID;
            this.AppTypeTitle = Title;
            this.AppTypeFees = Fees;
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
        
        public bool UpdateTypeInfo(string NewTitle , float NewFees )
        {
            return clApplicationTypeData.UpdateAppType(this.AppTypeID, NewTitle, NewFees);
        }
    }
}
