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
    public class CharacteristicsController : ControllerBase
    {
        private readonly DataContext _context;

        public CharacteristicsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Characteristics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Characteristics>>> GetCharacteristics()
        {
          if (_context.Characteristics == null)
          {
              return NotFound();
          }
            return await _context.Characteristics.ToListAsync();
        }

        // GET: api/Characteristics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Characteristics>> GetCharacteristics(int id)
        {
          if (_context.Characteristics == null)
          {
              return NotFound();
          }
            var characteristics = await _context.Characteristics.FindAsync(id);

            if (characteristics == null)
            {
                return NotFound();
            }

            return characteristics;
        }

        // PUT: api/Characteristics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacteristics(int id, Characteristics characteristics)
        {
            if (id != characteristics.CharacteristicsID)
            {
                return BadRequest();
            }

            _context.Entry(characteristics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacteristicsExists(id))
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

        // POST: api/Characteristics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Characteristics>> PostCharacteristics(Characteristics characteristics)
        {
          if (_context.Characteristics == null)
          {
              return Problem("Entity set 'DataContext.Characteristics'  is null.");
          }
            _context.Characteristics.Add(characteristics);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacteristics", new { id = characteristics.CharacteristicsID }, characteristics);
        }

        // DELETE: api/Characteristics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacteristics(int id)
        {
            if (_context.Characteristics == null)
            {
                return NotFound();
            }
            var characteristics = await _context.Characteristics.FindAsync(id);
            if (characteristics == null)
            {
                return NotFound();
            }

            _context.Characteristics.Remove(characteristics);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacteristicsExists(int id)
        {
            return (_context.Characteristics?.Any(e => e.CharacteristicsID == id)).GetValueOrDefault();
        }
    }
}
