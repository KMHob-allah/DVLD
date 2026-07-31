using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    static internal class clDateHelper
    {
        static public int CalculateAgeInYears(DateTime BirthDate)
        {
            int Age = DateTime.Today.Year - BirthDate.Year;

            if (BirthDate.Date > DateTime.Today.AddYears(-Age)) --Age;

            return Age;

        }
    }
}
