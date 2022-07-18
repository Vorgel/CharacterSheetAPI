using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroStatsController : ControllerBase
    {
        private readonly DataContext _context;

        public HeroStatsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/HeroStats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeroStats>>> GetHeroStats()
        {
            if (_context.HeroStats == null)
            {
                return NotFound();
            }

            return await _context.HeroStats.ToListAsync();
        }

        // GET: api/HeroStats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HeroStats>> GetHeroStat(int id)
        {
            if (_context.HeroStats == null)
            {
                return NotFound();
            }
            var heroStats = await _context.HeroStats.FindAsync(id);

            if (heroStats == null)
            {
                return NotFound();
            }

            return heroStats;
        }

        // PUT: api/HeroStats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHeroStats(int id, HeroStats heroStats)
        {
            if (id != heroStats.CharacterID)
            {
                return BadRequest();
            }

            _context.Entry(heroStats).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroStatsExists(id))
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

        // POST: api/HeroStats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HeroStats>> PostHeroStats(HeroStats heroStats)
        {
            if (_context.HeroStats == null)
            {
                return Problem("Entity set 'DataContext.HeroStats'  is null.");
            }
            _context.HeroStats.Add(heroStats);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHeroStats", new { id = heroStats.CharacterID }, heroStats);
        }

        // DELETE: api/HeroStats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHeroStats(int id)
        {
            if (_context.HeroStats == null)
            {
                return NotFound();
            }
            var heroStats = await _context.HeroStats.FindAsync(id);
            if (heroStats == null)
            {
                return NotFound();
            }

            _context.HeroStats.Remove(heroStats);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HeroStatsExists(int id)
        {
            return (_context.HeroStats?.Any(e => e.CharacterID == id)).GetValueOrDefault();
        }
    }
}
