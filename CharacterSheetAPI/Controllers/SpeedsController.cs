using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeedsController : ControllerBase
    {
        private readonly DataContext _context;

        public SpeedsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Speeds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Speed>>> GetSpeeds()
        {
            if (_context.Speeds == null)
            {
                return NotFound();
            }

            return await _context.Speeds.ToListAsync();
        }

        // GET: api/Speeds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Speed>> GetSpeed(int id)
        {
            if (_context.Speeds == null)
            {
                return NotFound();
            }
            var speed = await _context.Speeds.FindAsync(id);

            if (speed == null)
            {
                return NotFound();
            }

            return speed;
        }

        // PUT: api/Speeds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpeed(int id, Speed speed)
        {
            if (id != speed.CharacterID)
            {
                return BadRequest();
            }

            _context.Entry(speed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpeedExists(id))
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

        // POST: api/Speeds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Speed>> PostSpeed(Speed speed)
        {
            if (_context.Speeds == null)
            {
                return Problem("Entity set 'DataContext.Speeds'  is null.");
            }
            _context.Speeds.Add(speed);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpeed", new { id = speed.CharacterID }, speed);
        }

        // DELETE: api/Speeds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpeed(int id)
        {
            if (_context.Speeds == null)
            {
                return NotFound();
            }
            var speed = await _context.Speeds.FindAsync(id);
            if (speed == null)
            {
                return NotFound();
            }

            _context.Speeds.Remove(speed);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SpeedExists(int id)
        {
            return (_context.Speeds?.Any(e => e.CharacterID == id)).GetValueOrDefault();
        }
    }
}
