using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<Ambition>>> GetAmbitions()
        {
            if (_context.Ambitions == null)
            {
                return NotFound();
            }

            return await _context.Ambitions.ToListAsync();
        }

        // GET: api/Ambitions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ambition>> GetAmbition(int id)
        {
            if (_context.Ambitions == null)
            {
                return NotFound();
            }
            var ambition = await _context.Ambitions.FindAsync(id);

            if (ambition == null)
            {
                return NotFound();
            }

            return ambition;
        }

        // PUT: api/Ambitions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmbition(int id, Ambition ambition)
        {
            if (id != ambition.CharacterID)
            {
                return BadRequest();
            }

            _context.Entry(ambition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmbitionExists(id))
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
        public async Task<ActionResult<Ambition>> PostAmbition(Ambition ambition)
        {
            if (_context.Ambitions == null)
            {
                return Problem("Entity set 'DataContext.Ambitions'  is null.");
            }
            _context.Ambitions.Add(ambition);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmbition", new { id = ambition.CharacterID }, ambition);
        }

        // DELETE: api/Ambitions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmbition(int id)
        {
            if (_context.Ambitions == null)
            {
                return NotFound();
            }
            var ambition = await _context.Ambitions.FindAsync(id);
            if (ambition == null)
            {
                return NotFound();
            }

            _context.Ambitions.Remove(ambition);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AmbitionExists(int id)
        {
            return (_context.Ambitions?.Any(e => e.CharacterID == id)).GetValueOrDefault();
        }
    }
}
