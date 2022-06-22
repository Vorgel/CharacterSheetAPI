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
    public class AmbitionsController : ControllerBase
    {
        private readonly DataContext _context;

        public AmbitionsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Ambitions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ambitions>>> GetAmbitions()
        {
          if (_context.Ambitions == null)
          {
              return NotFound();
          }
            return await _context.Ambitions.ToListAsync();
        }

        // GET: api/Ambitions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ambitions>> GetAmbitions(int id)
        {
          if (_context.Ambitions == null)
          {
              return NotFound();
          }
            var ambitions = await _context.Ambitions.FindAsync(id);

            if (ambitions == null)
            {
                return NotFound();
            }

            return ambitions;
        }

        // PUT: api/Ambitions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmbitions(int id, Ambitions ambitions)
        {
            if (id != ambitions.AmbitionsID)
            {
                return BadRequest();
            }

            _context.Entry(ambitions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmbitionsExists(id))
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

        // POST: api/Ambitions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ambitions>> PostAmbitions(Ambitions ambitions)
        {
          if (_context.Ambitions == null)
          {
              return Problem("Entity set 'DataContext.Ambitions'  is null.");
          }
            _context.Ambitions.Add(ambitions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmbitions", new { id = ambitions.AmbitionsID }, ambitions);
        }

        // DELETE: api/Ambitions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmbitions(int id)
        {
            if (_context.Ambitions == null)
            {
                return NotFound();
            }
            var ambitions = await _context.Ambitions.FindAsync(id);
            if (ambitions == null)
            {
                return NotFound();
            }

            _context.Ambitions.Remove(ambitions);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AmbitionsExists(int id)
        {
            return (_context.Ambitions?.Any(e => e.AmbitionsID == id)).GetValueOrDefault();
        }
    }
}
