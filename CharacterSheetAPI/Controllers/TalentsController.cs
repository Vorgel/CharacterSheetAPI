using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentsController : ControllerBase
    {
        private readonly DataContext _context;

        public TalentsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Talents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Talent>>> GetTalents(int characterID = 0)
        {
            if (_context.Talents == null)
            {
                return NotFound();
            }

            return characterID == 0 ?
                  await _context.Talents.ToListAsync() :
                  await _context.Talents.Where(x => x.CharacterID == characterID).ToListAsync();
        }

        // GET: api/Talents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Talent>> GetTalent(int id)
        {
            if (_context.Talents == null)
            {
                return NotFound();
            }
            var talent = await _context.Talents.FindAsync(id);

            if (talent == null)
            {
                return NotFound();
            }

            return talent;
        }

        // PUT: api/Talents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTalent(int id, Talent talent)
        {
            if (id != talent.TalentID)
            {
                return BadRequest();
            }

            _context.Entry(talent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalentExists(id))
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

        // POST: api/Talents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Talent>> PostTalent(Talent talent)
        {
            if (_context.Talents == null)
            {
                return Problem("Entity set 'DataContext.Talents'  is null.");
            }
            _context.Talents.Add(talent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTalent", new { id = talent.TalentID }, talent);
        }

        // DELETE: api/Talents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTalent(int id)
        {
            if (_context.Talents == null)
            {
                return NotFound();
            }
            var talent = await _context.Talents.FindAsync(id);
            if (talent == null)
            {
                return NotFound();
            }

            _context.Talents.Remove(talent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TalentExists(int id)
        {
            return (_context.Talents?.Any(e => e.TalentID == id)).GetValueOrDefault();
        }
    }
}
