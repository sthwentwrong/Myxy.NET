using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Myxy.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetadatasController : ControllerBase
    {
        private readonly MyxyContext _context;

        private readonly ILogger<MetadatasController> _logger;

        public MetadatasController(MyxyContext context)
        {
            _context = context;
        }

        // GET: api/Metadatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AzDOMetadata>>> GetAzDOMetadata()
        {
            return await _context.AzDOMetadata.ToListAsync();
        }

        // GET: api/Metadatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AzDOMetadata>> GetAzDOMetadata(string id)
        {
            var azDOMetadata = await _context.AzDOMetadata.FindAsync(id);

            if (azDOMetadata == null)
            {
                return NotFound();
            }

            return azDOMetadata;
        }

        // PUT: api/Metadatas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAzDOMetadata(string id, AzDOMetadata azDOMetadata)
        {
            if (id != azDOMetadata.Id)
            {
                return BadRequest();
            }

            _context.Entry(azDOMetadata).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AzDOMetadataExists(id))
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

        // POST: api/Metadatas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AzDOMetadata>> PostAzDOMetadata(AzDOMetadata azDOMetadata)
        {
            _context.AzDOMetadata.Add(azDOMetadata);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AzDOMetadataExists(azDOMetadata.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAzDOMetadata", new { id = azDOMetadata.Id }, azDOMetadata);
        }

        // DELETE: api/Metadatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAzDOMetadata(string id)
        {
            var azDOMetadata = await _context.AzDOMetadata.FindAsync(id);
            if (azDOMetadata == null)
            {
                return NotFound();
            }

            _context.AzDOMetadata.Remove(azDOMetadata);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AzDOMetadataExists(string id)
        {
            return _context.AzDOMetadata.Any(e => e.Id == id);
        }
    }
}
