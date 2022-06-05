using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankTest.Models;
using System.Globalization;

namespace BankTest.Data
{
    public class BankTestContext : DbContext
    {
        public BankTestContext (DbContextOptions<BankTestContext> options)
            : base(options)
        {
        }

        public DbSet<BankTest.Models.Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string[] firstName = { "Jhon", "Brayan", "Tedd", "Carlos", "Miguel", "Marcos", "Juliet" };
            string[] lastName = { "Doe", "Hernandez", "Fernandez", "Garcia", "Stampton", "Lee", "Tapanez" };
            string[] imagesUrl = { "img_avatar1.png", "img_avatar2.png", "img_avatar3.png", "img_avatar4.png", "img_avatar5.png" };
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                string fn = firstName[rand.Next(0, firstName.Length)];
                string ln = lastName[rand.Next(0, lastName.Length)];
                DateTime dayOfBirth = DateTime.Now.AddYears(-rand.Next(10, 80));
                var contact = new Contact
                {
                    ID = i + 1,
                    FirstName = fn,
                    SecondName = ln,
                    Addresses = "Some Adress " + i,
                    DateofBirth = dayOfBirth, ///DateTime.Parse(dayOfBirth.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)) ,
                    PhoneNumber = rand.Next(10000000, 100000000).ToString(),
                    PersonalPhoto = imagesUrl[rand.Next(0, imagesUrl.Length)]
                };
                modelBuilder.Entity<Contact>().HasData(contact);
            }
            

        }
    }
}
