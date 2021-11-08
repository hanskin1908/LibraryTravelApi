using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;

namespace LibraryTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresHasLibroesController : ControllerBase
    {
        private readonly Library_Browser_TravelContext _context;

        public AutoresHasLibroesController(Library_Browser_TravelContext context)
        {
            _context = context;
        }

        // GET: api/AutoresHasLibroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AutoresHasLibro>>> GetAutoresHasLibros()
        {
            return await _context.AutoresHasLibros.ToListAsync();
        }

        // GET: api/AutoresHasLibroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AutoresHasLibro>> GetAutoresHasLibro(int id)
        {
            var autoresHasLibro = await _context.AutoresHasLibros.FindAsync(id);

            if (autoresHasLibro == null)
            {
                return NotFound();
            }

            return autoresHasLibro;
        }

        // PUT: api/AutoresHasLibroes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutoresHasLibro(int id, AutoresHasLibro autoresHasLibro)
        {
            if (id != autoresHasLibro.AutoresId)
            {
                return BadRequest();
            }

            _context.Entry(autoresHasLibro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoresHasLibroExists(id))
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

        // POST: api/AutoresHasLibroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AutoresHasLibro>> PostAutoresHasLibro(AutoresHasLibro autoresHasLibro)
        {
            _context.AutoresHasLibros.Add(autoresHasLibro);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AutoresHasLibroExists(autoresHasLibro.AutoresId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAutoresHasLibro", new { id = autoresHasLibro.AutoresId }, autoresHasLibro);
        }

        // DELETE: api/AutoresHasLibroes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutoresHasLibro(int id)
        {
            var autoresHasLibro = await _context.AutoresHasLibros.FindAsync(id);
            if (autoresHasLibro == null)
            {
                return NotFound();
            }

            _context.AutoresHasLibros.Remove(autoresHasLibro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutoresHasLibroExists(int id)
        {
            return _context.AutoresHasLibros.Any(e => e.AutoresId == id);
        }
    }
}
