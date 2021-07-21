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
    public class E2EOnWindowsController : ControllerBase
    {
        private readonly MyxyNETContext _context;

        public E2EOnWindowsController(MyxyNETContext context)
        {
            _context = context;
        }

        // GET: api/E2EOnWindows
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E2EOnWindows>>> GetE2EOnWindows()
        {
            return await _context.E2EOnWindows.ToListAsync();
        }

        // GET: api/E2EOnWindows/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E2EOnWindows>> GetE2EOnWindows(string id)
        {
            var e2EOnWindows = await _context.E2EOnWindows.FindAsync(id);

            if (e2EOnWindows == null)
            {
                return NotFound();
            }

            return e2EOnWindows;
        }

        // PUT: api/E2EOnWindows/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE2EOnWindows(string id, E2EOnWindows e2EOnWindows)
        {
            if (id != e2EOnWindows.Id)
            {
                return BadRequest();
            }

            _context.Entry(e2EOnWindows).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E2EOnWindowsExists(id))
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

        // POST: api/E2EOnWindows
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E2EOnWindows>> PostE2EOnWindows(E2EOnWindows e2EOnWindows)
        {
            _context.E2EOnWindows.Add(e2EOnWindows);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E2EOnWindowsExists(e2EOnWindows.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE2EOnWindows", new { id = e2EOnWindows.Id }, e2EOnWindows);
        }

        // DELETE: api/E2EOnWindows/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE2EOnWindows(string id)
        {
            var e2EOnWindows = await _context.E2EOnWindows.FindAsync(id);
            if (e2EOnWindows == null)
            {
                return NotFound();
            }

            _context.E2EOnWindows.Remove(e2EOnWindows);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E2EOnWindowsExists(string id)
        {
            return _context.E2EOnWindows.Any(e => e.Id == id);
        }
    }
}
