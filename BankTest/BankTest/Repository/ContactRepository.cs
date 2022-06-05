using BankTest.Data;
using BankTest.DTO;
using BankTest.Filters;
using BankTest.Models;
using BankTest.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BankTest.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly BankTestContext _context; // use dependecy injection

        public ContactRepository(BankTestContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ContactDTO>> GetAll()
        {
            IEnumerable<Contact> contacts = await _context.Contact.ToListAsync();

            List<ContactDTO> vm = new List<ContactDTO>();
            foreach (var c in contacts)
            {
                vm.Add(map(c));
            }
            return vm;
        }

        public async Task<ContactDTO> GetByID(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
           // var z = toDto(contact);
            return map(contact);
        }


        public async Task Create(Contact contact)
        {
            _context.Contact.Add(contact);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Contact contact)
        {
            _context.Entry(contact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }
        }

        public async Task<IEnumerable<ContactDTO>> Search(ContactFilter contactFilter)
        {
            
            IQueryable<Contact> query = _context.Contact;
            if (contactFilter.FirstName != null)
            {
                query = query.Where(c => c.FirstName.ToLower().Contains(contactFilter.FirstName.ToLower().Trim()));
            }
            if (contactFilter.SecondName != null)
            {
                query = query.Where(c => c.SecondName.ToLower().Contains(contactFilter.SecondName.ToLower().Trim()));
            }

            if (contactFilter.Address != null)
            {
                query = query.Where(c => c.Addresses.ToLower().Contains(contactFilter.Address.ToLower().Trim()));
            }
          
           
            if (contactFilter.FromAge != 0)
            {
                DateTime back = DateTime.Now.AddYears(-contactFilter.FromAge);
                query = query.Where(c => c.DateofBirth <= back);
                // query = query.Where(c => Utility.GetAge(c.DateofBirth) >= contactFilter.FromAge);
            }
            if (contactFilter.ToAge != 0)
            {
                DateTime forward = DateTime.Now.AddYears(-contactFilter.ToAge);
                query = query.Where(c => c.DateofBirth >= forward);
                //query = query.Where(c => Utility.GetAge(c.DateofBirth) <= contactFilter.ToAge);
            }
            
            IEnumerable<Contact> contacts = await query.ToListAsync();

            List<ContactDTO> vm = new List<ContactDTO>();
            foreach (var c in contacts)
            {
                vm.Add(map(c));
            }
            return vm;

        }

        private ContactDTO map(Contact c)
        {
            return c==null ? null : new ContactDTO
            {
                ID = c.ID,
                FirstName = c.FirstName,
                SecondName = c.SecondName,
                Addresses = c.Addresses,
                DateofBirth = c.DateofBirth.ToString(Utility.formatter),
                PhoneNumber = c.PhoneNumber,
                Age = Utility.GetAge(c.DateofBirth),
                PersonalPhoto = c.PersonalPhoto
            };
        }


      /*
        public static Expression<Func<Contact, ContactDTO>> toDto =
       c => c == null ? null : new ContactDTO
       {
           ID = c.ID,
           FirstName = c.FirstName,
           SecondName = c.SecondName,
           Addresses = c.Addresses,
           DateofBirth = c.DateofBirth.ToString(Utility.formatter),
           PhoneNumber = c.PhoneNumber,
           Age = Utility.GetAge(c.DateofBirth),
           PersonalPhoto = c.PersonalPhoto
       };
      */

    }
}
