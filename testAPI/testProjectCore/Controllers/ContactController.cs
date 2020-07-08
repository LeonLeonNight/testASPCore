using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testProjectCore.Data;
using testProjectCore.Models;

namespace testProjectCore.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private ContactContext _db;
        public ContactController(ContactContext accountContext)
        {
            _db = accountContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContactList()
        {
            var acList = await _db.Contacts.ToListAsync();
            return acList;
        }

        // GET <controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContactById(int accountId)
        {
            var account = await _db.Contacts.FirstOrDefaultAsync(x => x.Id == accountId);
            if (account == null)
            {
                return NotFound();
            }
            return new ObjectResult(account);
        }

        // POST <controller>
        [HttpPost]
        public async Task<ActionResult<Contact>> CreateContact(Contact account)
        {
            if (account == null)
            {
                return BadRequest();
            }
            _db.Contacts.Add(account);
            await _db.SaveChangesAsync();
            return Ok(account);
        }

        // PUT <controller>
        [HttpPut]
        public async Task<ActionResult<Contact>> UpdateContact(Contact account)
        {
            if (account == null)
            {
                return BadRequest();
            }

            if (!_db.Contacts.Any(x => x.Id == account.Id))
            {
                return NotFound();
            }

            _db.Update(account);
            await _db.SaveChangesAsync();
            return Ok(account);
        }

        // DELETE <controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Contact>> DeleteContact(int accountId)
        {
            Contact account = _db.Contacts.FirstOrDefault(x => x.Id == accountId);
            if (account == null)
                return NotFound();
            _db.Contacts.Remove(account);
            await _db.SaveChangesAsync();
            return Ok(account);
        }
    }
}
