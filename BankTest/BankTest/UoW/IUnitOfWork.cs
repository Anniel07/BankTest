using BankTest.Repos.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        // add all repositories below
        IContactRepository Contacts { get; }

        Task<bool> SaveChangesAsync();
    }
}
