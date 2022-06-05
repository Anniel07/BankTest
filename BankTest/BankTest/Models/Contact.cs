using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage ="The max length must be 40 characteres.")]
        public string FirstName { get; set; }
        public string SecondName { get; set; } // nullable

        public string Addresses { get; set; } // nullable

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateofBirth { get; set; }

        [Phone]
        public string PhoneNumber { get; set; } // nullable

        public string PersonalPhoto { get; set; }  // nullable
    }
}
