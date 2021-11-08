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
    public class EditorialesController : ControllerBase
    {
        private readonly Library_Browser_TravelContext _context;

        public EditorialesController(Library_Browser_TravelContext context)
        {
            _context = context;
        }

        // GET: api/Editoriales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Editoriale>>> GetEditoriales()
        {
            return await _context.Editoriales.ToListAsync();
        }

        // GET: api/Editoriales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Editoriale>> GetEditoriale(int id)
        {
            var editoriale = await _context.Editoriales.FindAsync(id);

            if (editoriale == null)
            {
                return NotFound();
            }

            return editoriale;
        }

        // PUT: api/Editoriales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEditoriale(int id, Editoriale editoriale)
        {
            if (id != editoriale.Id)
            {
                return BadRequest();
            }

            _context.Entry(editoriale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EditorialeExists(id))
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

        // POST: api/Editoriales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Editoriale>> PostEditoriale(Editoriale editoriale)
        {
            _context.Editoriales.Add(editoriale);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEditoriale", new { id = editoriale.Id }, editoriale);
        }

        // DELETE: api/Editoriales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEditoriale(int id)
        {
            var editoriale = await _context.Editoriales.FindAsync(id);
            if (editoriale == null)
            {
                return NotFound();
            }

            _context.Editoriales.Remove(editoriale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EditorialeExists(int id)
        {
            return _context.Editoriales.Any(e => e.Id == id);
        }
    }
}
