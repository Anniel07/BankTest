using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.Filters
{
    public class ContactFilter
    {
        
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Address { get; set; }
        public int FromAge { get; set; }
        public int ToAge { get; set; }
    }
}
