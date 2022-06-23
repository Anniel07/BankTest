using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.Filters
{

    // filtros para buscar por criterios
    public class ContactFilter : BaseFilter
    {
        
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Address { get; set; }
        public int FromAge { get; set; }
        public int ToAge { get; set; }

    }
}
