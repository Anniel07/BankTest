using BankTest.Data;
using BankTest.Repos.IRepository;
using BankTest.Repos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly BankTestContext _context; // use dependecy injection

        // add all repositories below
        public IContactRepository Contacts { get; }

        public UnitOfWork(BankTestContext context) {
            _context = context;
            Contacts = new ContactRepository(context); // define clase que implementa la interfaz
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
