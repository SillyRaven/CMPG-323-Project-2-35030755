using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2_IoT_Management.Models;

namespace IoT_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZonesController : ControllerBase
    {
        private readonly ZoneContext _context;

        public ZonesController(ZoneContext context)
        {
            _context = context;
        }

        // GET: api/Zones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Zones>>> GetZones()
        {
          if (_context.Zones == null)
          {
              return NotFound();
          }
            return await _context.Zones.ToListAsync();
        }

        // GET: api/Zones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Zones>> GetZones(long id)
        {
          if (_context.Zones == null)
          {
              return NotFound();
          }
            var zones = await _context.Zones.FindAsync(id);

            if (zones == null)
            {
                return NotFound();
            }

            return zones;
        }

        // PUT: api/Zones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZones(long id, Zones zones)
        {
            if (id != zones.ZoneID)
            {
                return BadRequest();
            }

            _context.Entry(zones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZonesExists(id))
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

        // POST: api/Zones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Zones>> PostZones(Zones zones)
        {
          if (_context.Zones == null)
          {
              return Problem("Entity set 'ZoneContext.Zones'  is null.");
          }
            _context.Zones.Add(zones);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetZones), new { id = zones.ZoneID }, zones);
        }

        // DELETE: api/Zones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZones(long id)
        {
            if (_context.Zones == null)
            {
                return NotFound();
            }
            var zones = await _context.Zones.FindAsync(id);
            if (zones == null)
            {
                return NotFound();
            }

            _context.Zones.Remove(zones);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ZonesExists(long id)
        {
            return (_context.Zones?.Any(e => e.ZoneID == id)).GetValueOrDefault();
        }
    }
}
