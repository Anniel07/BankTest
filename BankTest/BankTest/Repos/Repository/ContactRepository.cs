using BankTest.Data;
using BankTest.DTO;
using BankTest.Filters;
using BankTest.Models;
using BankTest.Repos.IRepository;
using BankTest.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BankTest.Repos.Repository
{
    public class ContactRepository : GenericRepository<Contact> , IContactRepository
    {
        public ContactRepository(BankTestContext context) : base(context){ 
        
        }
       

    }
}
