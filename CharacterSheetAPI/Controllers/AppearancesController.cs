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
    public class AppearancesController : ControllerBase
    {
        private readonly DataContext _context;

        public AppearancesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Appearances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appearance>>> GetAppearances()
        {
          if (_context.Appearances == null)
          {
              return NotFound();
          }
            return await _context.Appearances.ToListAsync();
        }

        // GET: api/Appearances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Appearance>> GetAppearance(int id)
        {
          if (_context.Appearances == null)
          {
              return NotFound();
          }
            var appearance = await _context.Appearances.FindAsync(id);

            if (appearance == null)
            {
                return NotFound();
            }

            return appearance;
        }

        // PUT: api/Appearances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppearance(int id, Appearance appearance)
        {
            if (id != appearance.AppearanceID)
            {
                return BadRequest();
            }

            _context.Entry(appearance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppearanceExists(id))
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

        // POST: api/Appearances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Appearance>> PostAppearance(Appearance appearance)
        {
          if (_context.Appearances == null)
          {
              return Problem("Entity set 'DataContext.Appearances'  is null.");
          }
            _context.Appearances.Add(appearance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppearance", new { id = appearance.AppearanceID }, appearance);
        }

        // DELETE: api/Appearances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppearance(int id)
        {
            if (_context.Appearances == null)
            {
                return NotFound();
            }
            var appearance = await _context.Appearances.FindAsync(id);
            if (appearance == null)
            {
                return NotFound();
            }

            _context.Appearances.Remove(appearance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppearanceExists(int id)
        {
            return (_context.Appearances?.Any(e => e.AppearanceID == id)).GetValueOrDefault();
        }
    }
}
