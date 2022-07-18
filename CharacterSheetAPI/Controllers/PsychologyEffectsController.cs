using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PsychologyEffectsController : ControllerBase
    {
        private readonly DataContext _context;

        public PsychologyEffectsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PsychologyEffects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PsychologyEffect>>> GetPsychologyEffects(int characterID = 0)
        {
            if (_context.PsychologyEffect == null)
            {
                return NotFound();
            }

            return characterID == 0 ?
                  await _context.PsychologyEffect.ToListAsync() :
                  await _context.PsychologyEffect.Where(x => x.CharacterID == characterID).ToListAsync();
        }

        // GET: api/PsychologyEffects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PsychologyEffect>> GetPsychologyEffect(int id)
        {
            if (_context.PsychologyEffect == null)
            {
                return NotFound();
            }
            var psychologyEffect = await _context.PsychologyEffect.FindAsync(id);

            if (psychologyEffect == null)
            {
                return NotFound();
            }

            return psychologyEffect;
        }

        // PUT: api/PsychologyEffects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPsychologyEffect(int id, PsychologyEffect psychologyEffect)
        {
            if (id != psychologyEffect.PsychologyEffectID)
            {
                return BadRequest();
            }

            _context.Entry(psychologyEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PsychologyEffectExists(id))
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

        // POST: api/PsychologyEffects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PsychologyEffect>> PostPsychologyEffect(PsychologyEffect psychologyEffect)
        {
            if (_context.PsychologyEffect == null)
            {
                return Problem("Entity set 'DataContext.PsychologyEffect'  is null.");
            }
            _context.PsychologyEffect.Add(psychologyEffect);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPsychologyEffect", new { id = psychologyEffect.PsychologyEffectID }, psychologyEffect);
        }

        // DELETE: api/PsychologyEffects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePsychologyEffect(int id)
        {
            if (_context.PsychologyEffect == null)
            {
                return NotFound();
            }
            var psychologyEffect = await _context.PsychologyEffect.FindAsync(id);
            if (psychologyEffect == null)
            {
                return NotFound();
            }

            _context.PsychologyEffect.Remove(psychologyEffect);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PsychologyEffectExists(int id)
        {
            return (_context.PsychologyEffect?.Any(e => e.PsychologyEffectID == id)).GetValueOrDefault();
        }
    }
}
