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
    public class AutoresController : ControllerBase
    {
        private readonly Library_Browser_TravelContext _context;

        public AutoresController(Library_Browser_TravelContext context)
        {
            _context = context;
        }

        // GET: api/Autores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autore>>> GetAutores()
        {
            return await _context.Autores.ToListAsync();
        }

        // GET: api/Autores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Autore>> GetAutore(int id)
        {
            var autore = await _context.Autores.FindAsync(id);

            if (autore == null)
            {
                return NotFound();
            }

            return autore;
        }

        // PUT: api/Autores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutore(int id, Autore autore)
        {
            if (id != autore.Id)
            {
                return BadRequest();
            }

            _context.Entry(autore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoreExists(id))
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

        // POST: api/Autores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Autore>> PostAutore(Autore autore)
        {
            _context.Autores.Add(autore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutore", new { id = autore.Id }, autore);
        }

        // DELETE: api/Autores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutore(int id)
        {
            var autore = await _context.Autores.FindAsync(id);
            if (autore == null)
            {
                return NotFound();
            }

            _context.Autores.Remove(autore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutoreExists(int id)
        {
            return _context.Autores.Any(e => e.Id == id);
        }
    }
}
