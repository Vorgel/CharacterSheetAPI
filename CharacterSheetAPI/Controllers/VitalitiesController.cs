using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VitalitiesController : ControllerBase
    {
        private readonly DataContext _context;

        public VitalitiesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Vitalities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vitality>>> GetVitalities()
        {
            if (_context.Vitalities == null)
            {
                return NotFound();
            }

            return await _context.Vitalities.ToListAsync();
        }

        // GET: api/Vitalities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vitality>> GetVitality(int id)
        {
            if (_context.Vitalities == null)
            {
                return NotFound();
            }
            var vitality = await _context.Vitalities.FindAsync(id);

            if (vitality == null)
            {
                return NotFound();
            }

            return vitality;
        }

        // PUT: api/Vitalities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVitality(int id, Vitality vitality)
        {
            if (id != vitality.CharacterID)
            {
                return BadRequest();
            }

            _context.Entry(vitality).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VitalityExists(id))
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

        // POST: api/Vitalities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vitality>> PostVitality(Vitality vitality)
        {
            if (_context.Vitalities == null)
            {
                return Problem("Entity set 'DataContext.Vitalities'  is null.");
            }
            _context.Vitalities.Add(vitality);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVitality", new { id = vitality.CharacterID }, vitality);
        }

        // DELETE: api/Vitalities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVitality(int id)
        {
            if (_context.Vitalities == null)
            {
                return NotFound();
            }
            var vitality = await _context.Vitalities.FindAsync(id);
            if (vitality == null)
            {
                return NotFound();
            }

            _context.Vitalities.Remove(vitality);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VitalityExists(int id)
        {
            return (_context.Vitalities?.Any(e => e.CharacterID == id)).GetValueOrDefault();
        }
    }
}
