using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clCountry()
        {
            CountryID = -1;
            CountryName = string.Empty;
        }
        private clCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        static public clCountry Find(int CountryID)
        {
            string CountryName = string.Empty;

            if (clCountryData.LoadCountry(CountryID, ref CountryName))
            {
                return new clCountry(CountryID, CountryName);

            }
            else return null;
        }
        static public clCountry Find(string CountryName)
        {
            int CountryID = -1;

            if (clCountryData.LoadCountry(ref CountryID, CountryName))
            {
                return new clCountry(CountryID, CountryName);

            }
            else return null;
        }

        static public DataTable GetAllCountries()
        {
            return clCountryData.LoadAllCountries();
        }
    }
}
