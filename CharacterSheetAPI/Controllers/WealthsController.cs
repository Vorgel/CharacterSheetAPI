using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WealthsController : ControllerBase
    {
        private readonly DataContext _context;

        public WealthsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Wealths
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wealth>>> GetWealths()
        {
            if (_context.Wealths == null)
            {
                return NotFound();
            }

            return await _context.Wealths.ToListAsync();
        }

        // GET: api/Wealths/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Wealth>> GetWealth(int id)
        {
            if (_context.Wealths == null)
            {
                return NotFound();
            }
            var wealth = await _context.Wealths.FindAsync(id);

            if (wealth == null)
            {
                return NotFound();
            }

            return wealth;
        }

        // PUT: api/Wealths/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWealth(int id, Wealth wealth)
        {
            if (id != wealth.CharacterID)
            {
                return BadRequest();
            }

            _context.Entry(wealth).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WealthExists(id))
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

        // POST: api/Wealths
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Wealth>> PostWealth(Wealth wealth)
        {
            if (_context.Wealths == null)
            {
                return Problem("Entity set 'DataContext.Wealths'  is null.");
            }
            _context.Wealths.Add(wealth);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWealth", new { id = wealth.CharacterID }, wealth);
        }

        // DELETE: api/Wealths/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWealth(int id)
        {
            if (_context.Wealths == null)
            {
                return NotFound();
            }
            var wealth = await _context.Wealths.FindAsync(id);
            if (wealth == null)
            {
                return NotFound();
            }

            _context.Wealths.Remove(wealth);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WealthExists(int id)
        {
            return (_context.Wealths?.Any(e => e.CharacterID == id)).GetValueOrDefault();
        }
    }
}
