using CharacterSheetAPI.Data;
using CharacterSheetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmorsController : ControllerBase
    {
        private readonly DataContext _context;

        public ArmorsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Armors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Armor>>> GetArmors(int characterID = 0)
        {
            if (_context.Armors == null)
            {
                return NotFound();
            }

            return characterID == 0 ?
                  await _context.Armors.ToListAsync() :
                  await _context.Armors.Where(x => x.CharacterID == characterID).ToListAsync();
        }

        // GET: api/Armors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Armor>> GetArmor(int id)
        {
            if (_context.Armors == null)
            {
                return NotFound();
            }
            var armor = await _context.Armors.FindAsync(id);

            if (armor == null)
            {
                return NotFound();
            }

            return armor;
        }

        // PUT: api/Armors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArmor(int id, Armor armor)
        {
            if (id != armor.ArmorID)
            {
                return BadRequest();
            }

            _context.Entry(armor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmorExists(id))
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

        // POST: api/Armors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Armor>> PostArmor(Armor armor)
        {
            if (_context.Armors == null)
            {
                return Problem("Entity set 'DataContext.Armors'  is null.");
            }
            _context.Armors.Add(armor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArmor", new { id = armor.ArmorID }, armor);
        }

        // DELETE: api/Armors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArmor(int id)
        {
            if (_context.Armors == null)
            {
                return NotFound();
            }
            var armor = await _context.Armors.FindAsync(id);
            if (armor == null)
            {
                return NotFound();
            }

            _context.Armors.Remove(armor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArmorExists(int id)
        {
            return (_context.Armors?.Any(e => e.ArmorID == id)).GetValueOrDefault();
        }
    }
}
