using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankTest.Data;
using BankTest.Models;
using BankTest.DTO;

using BankTest.Filters;
using System.Linq.Expressions;
using AutoMapper;
using BankTest.UoW;

namespace BankTest.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : EndPointControllerBase<Contact, ContactDto, ContactFilter>
    {
        //private readonly IMapper _mapper;
        //private readonly IUnitOfWork _repositories;

        public ContactsController(IMapper mapper, IUnitOfWork repositories) : base(mapper, repositories.Contacts)
        {
           // _mapper = mapper;
           // _repositories = repositories;
        }
      
        /// <summary>
        /// </summary>
        /// <param name="contactFilter"></param>
        /// <returns></returns>
        // GET: api/Contacts
        [HttpGet("GetPagedListAsync")]
        public async Task<ActionResult<PagedResultDto<ContactDto>>> GetContacts([FromQuery] ContactFilter contactFilter)
        {
            // make some validations
            if (contactFilter.ToAge != 0 && contactFilter.FromAge > contactFilter.ToAge)
            {
                return BadRequest("From age must be less than or equal ToAge");
            }
            // get pagedList
            var resp = await GetPagedListAsync(
                contactFilter,
                contactFilter.FirstName != null ? c => c.FirstName.ToLower().Contains(contactFilter.FirstName.ToLower().Trim()) : null,
                contactFilter.SecondName != null ? c => c.SecondName.ToLower().Contains(contactFilter.SecondName.ToLower().Trim()) : null,
                contactFilter.Address != null ? c => c.Addresses.ToLower().Contains(contactFilter.Address.ToLower().Trim()) : null,
                contactFilter.FromAge != 0 ? c => c.DateofBirth <= DateTime.Now.AddYears(-contactFilter.FromAge) : null,
                contactFilter.ToAge != 0 ? c => c.DateofBirth >= DateTime.Now.AddYears(-contactFilter.ToAge) : null);
            return Ok(resp);
            
        }
      
      
    }


}
