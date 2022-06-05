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
using BankTest.Repository;
using System.Linq.Expressions;


namespace BankTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        
        private readonly IContactRepository _repository;

        public ContactsController(IContactRepository repository)
        {
            _repository = repository;
        }

 
        // GET: api/Contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactDTO>>> GetContact()
        {
            IEnumerable<ContactDTO> contatcs = await _repository.GetAll();
            return Ok(contatcs);
        }

        // GET: api/Contacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactDTO>> GetContact(int id)
        {

            ContactDTO contact = await _repository.GetByID(id);
            if (contact == null)
            {
                return NotFound();
            }

            return contact;
           
        }
        
        // PUT: api/Contacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact(int id, Contact contact)
        {
            if (id != contact.ID)
            {
                return BadRequest();
            }

            await _repository.Update(contact);
            return NoContent();
        }
        
        // POST: api/Contacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            await _repository.Create(contact);
            return CreatedAtAction("GetContact", new { id = contact.ID }, contact);
        }
        
        // DELETE: api/Contacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _repository.GetByID(id);
            if (contact == null)
            {
                return NotFound();
            }
            await _repository.Delete(id);

            return NoContent();
        }
        

        [HttpGet("search")]

        public async Task<ActionResult<IEnumerable<ContactDTO>>> Search([FromQuery] ContactFilter contactFilter)
        {
            // validar q fromAge<= toAge
            if (contactFilter.ToAge != 0 && contactFilter.FromAge > contactFilter.ToAge) {
                return BadRequest("From age must be less than or equal ToAge");
            }
            IEnumerable<ContactDTO> contatcs = await _repository.Search(contactFilter);
            return Ok(contatcs);
            
            
        }

    }

}
