using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.Util
{
    public class Utility
    {   
        public static readonly string formatter = "yyyy-MM-dd";
        private Utility() {}
        public static int GetAge(DateTime bday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - bday.Year;
            // Are we before the birth date this year? If so subtract one year from the mix
            if (DateTime.Now.Month < bday.Month || (DateTime.Now.Month == bday.Month && DateTime.Now.Day < bday.Day))
            {
                age--;
            }
            return age;
        }
    }
}
