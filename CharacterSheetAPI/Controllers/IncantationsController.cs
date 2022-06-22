using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;

namespace CharacterSheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncantationsController : ControllerBase
    {
        private readonly DataContext _context;

        public IncantationsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Incantations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Incantation>>> GetIncantations()
        {
          if (_context.Incantations == null)
          {
              return NotFound();
          }
            return await _context.Incantations.ToListAsync();
        }

        // GET: api/Incantations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Incantation>> GetIncantation(int id)
        {
          if (_context.Incantations == null)
          {
              return NotFound();
          }
            var incantation = await _context.Incantations.FindAsync(id);

            if (incantation == null)
            {
                return NotFound();
            }

            return incantation;
        }

        // PUT: api/Incantations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncantation(int id, Incantation incantation)
        {
            if (id != incantation.IncantationID)
            {
                return BadRequest();
            }

            _context.Entry(incantation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncantationExists(id))
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

        // POST: api/Incantations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Incantation>> PostIncantation(Incantation incantation)
        {
          if (_context.Incantations == null)
          {
              return Problem("Entity set 'DataContext.Incantations'  is null.");
          }
            _context.Incantations.Add(incantation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIncantation", new { id = incantation.IncantationID }, incantation);
        }

        // DELETE: api/Incantations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncantation(int id)
        {
            if (_context.Incantations == null)
            {
                return NotFound();
            }
            var incantation = await _context.Incantations.FindAsync(id);
            if (incantation == null)
            {
                return NotFound();
            }

            _context.Incantations.Remove(incantation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IncantationExists(int id)
        {
            return (_context.Incantations?.Any(e => e.IncantationID == id)).GetValueOrDefault();
        }
    }
}
