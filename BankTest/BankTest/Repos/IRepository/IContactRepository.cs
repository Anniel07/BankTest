using BankTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.Repos.IRepository
{
    public interface IContactRepository: IGenericRepository<Contact>
    {
        // define operaiones particulares de IContactRepository aqui
    }
}
