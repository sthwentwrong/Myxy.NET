using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Myxy.NET;
using Myxy.NET.Data;

namespace Myxy.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AzDOController : ControllerBase
    {
        private readonly MyxyNETContext _context;
        private readonly ILogger<AzDOController> _logger;
        public AzDOController(MyxyNETContext context, ILogger<AzDOController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/AzDO
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AzDO>>> GetAzDO()
        {
            return await _context.AzDO.ToListAsync();
        }

        // GET: api/AzDO/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AzDO>> GetAzDO(string id)
        {
            var azDO = await _context.AzDO.FindAsync(id);

            if (azDO == null)
            {
                return NotFound();
            }

            return azDO;
        }

        // PUT: api/AzDO/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAzDO(string id, AzDO azDO)
        {
            if (id != azDO.Id)
            {
                return BadRequest();
            }

            _context.Entry(azDO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AzDOExists(id))
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

        // POST: api/AzDO
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AzDO>> PostAzDO(AzDO azDO)
        {
            _context.AzDO.Add(azDO);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AzDOExists(azDO.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAzDO", new { id = azDO.Id }, azDO);
        }

        // DELETE: api/AzDO/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAzDO(string id)
        {
            var azDO = await _context.AzDO.FindAsync(id);
            if (azDO == null)
            {
                return NotFound();
            }

            _context.AzDO.Remove(azDO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AzDOExists(string id)
        {
            return _context.AzDO.Any(e => e.Id == id);
        }
    }
}
