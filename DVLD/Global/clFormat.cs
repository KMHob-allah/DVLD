using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Global
{
    static public class clFormat
    {
        public static string DateToShort(DateTime Date)
        {
            return Date.ToString("dd/MMM/yyyy");
        }
    }
}
