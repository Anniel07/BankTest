using BankTest.Filters;
using BankTest.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankTest.Repository
{
    public interface IContactRepository
    {
        Task<IEnumerable<ContactDTO>> GetAll();

        Task<ContactDTO> GetByID(int id);

        Task Create(Contact contact);
        Task Delete(int id);
        Task Update(Contact contact);

        Task< IEnumerable<ContactDTO> > Search(ContactFilter contactFilter);
    }
}
