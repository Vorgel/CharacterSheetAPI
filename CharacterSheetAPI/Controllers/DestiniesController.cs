using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestiniesController : ControllerBase
    {
        private readonly DataContext _context;

        public DestiniesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Destinies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destiny>>> GetDestinies()
        {
            if (_context.Destinies == null)
            {
                return NotFound();
            }

            return await _context.Destinies.ToListAsync();
        }

        // GET: api/Destinies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Destiny>> GetDestiny(int id)
        {
            if (_context.Destinies == null)
            {
                return NotFound();
            }
            var destiny = await _context.Destinies.FindAsync(id);

            if (destiny == null)
            {
                return NotFound();
            }

            return destiny;
        }

        // PUT: api/Destinies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestiny(int id, Destiny destiny)
        {
            if (id != destiny.CharacterID)
            {
                return BadRequest();
            }

            _context.Entry(destiny).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinyExists(id))
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

        // POST: api/Destinies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Destiny>> PostDestiny(Destiny destiny)
        {
            if (_context.Destinies == null)
            {
                return Problem("Entity set 'DataContext.Destinies'  is null.");
            }
            _context.Destinies.Add(destiny);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDestiny", new { id = destiny.CharacterID }, destiny);
        }

        // DELETE: api/Destinies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestiny(int id)
        {
            if (_context.Destinies == null)
            {
                return NotFound();
            }
            var destiny = await _context.Destinies.FindAsync(id);
            if (destiny == null)
            {
                return NotFound();
            }

            _context.Destinies.Remove(destiny);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinyExists(int id)
        {
            return (_context.Destinies?.Any(e => e.CharacterID == id)).GetValueOrDefault();
        }
    }
}
