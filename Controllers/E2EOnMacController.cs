using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Myxy.NET;
using Myxy.NET.Data;

namespace Myxy.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class E2EOnMacController : ControllerBase
    {
        private readonly MyxyNETContext _context;

        public E2EOnMacController(MyxyNETContext context)
        {
            _context = context;
        }

        // GET: api/E2EOnMac
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E2EOnMac>>> GetE2EOnMac()
        {
            return await _context.E2EOnMac.ToListAsync();
        }

        // GET: api/E2EOnMac/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E2EOnMac>> GetE2EOnMac(string id)
        {
            var e2EOnMac = await _context.E2EOnMac.FindAsync(id);

            if (e2EOnMac == null)
            {
                return NotFound();
            }

            return e2EOnMac;
        }

        // PUT: api/E2EOnMac/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE2EOnMac(string id, E2EOnMac e2EOnMac)
        {
            if (id != e2EOnMac.Id)
            {
                return BadRequest();
            }

            _context.Entry(e2EOnMac).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E2EOnMacExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/E2EOnMac
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E2EOnMac>> PostE2EOnMac(E2EOnMac e2EOnMac)
        {
            _context.E2EOnMac.Add(e2EOnMac);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E2EOnMacExists(e2EOnMac.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE2EOnMac", new { id = e2EOnMac.Id }, e2EOnMac);
        }

        // DELETE: api/E2EOnMac/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE2EOnMac(string id)
        {
            var e2EOnMac = await _context.E2EOnMac.FindAsync(id);
            if (e2EOnMac == null)
            {
                return NotFound();
            }

            _context.E2EOnMac.Remove(e2EOnMac);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E2EOnMacExists(string id)
        {
            return _context.E2EOnMac.Any(e => e.Id == id);
        }
    }
}
