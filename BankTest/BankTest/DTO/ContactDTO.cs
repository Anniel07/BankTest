using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.DTO
{
    public class ContactDTO
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Addresses { get; set; }

        public string DateofBirth { get; set; }

       
        public string PhoneNumber { get; set; }

        public string PersonalPhoto { get; set; }

        public int Age { get; set; }

        public string FullName { get { return FirstName + " " + SecondName; } }
    }
}
