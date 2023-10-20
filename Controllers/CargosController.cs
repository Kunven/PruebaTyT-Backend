using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTyT_Backend.Models;

namespace PruebaTyT_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargosController : ControllerBase
    {
        private readonly PruebaContext _context;

        public CargosController(PruebaContext context)
        {
            _context = context;
        }

        // GET: api/Cargos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cargos>>> GetCargos()
        {
          if (_context.Cargos == null)
          {
              return NotFound();
          }
            return await _context.Cargos.ToListAsync();
        }

        // GET: api/Cargos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cargos>> GetCargos(int id)
        {
          if (_context.Cargos == null)
          {
              return NotFound();
          }
            var cargos = await _context.Cargos.FindAsync(id);

            if (cargos == null)
            {
                return NotFound();
            }

            return cargos;
        }

        // PUT: api/Cargos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCargos(int id, Cargos cargos)
        {
            if (id != cargos.id)
            {
                return BadRequest();
            }

            _context.Entry(cargos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CargosExists(id))
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

        // POST: api/Cargos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cargos>> PostCargos(Cargos cargos)
        {
          if (_context.Cargos == null)
          {
              return Problem("Entity set 'PruebaContext.Cargos'  is null.");
          }
            _context.Cargos.Add(cargos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCargos", new { id = cargos.id }, cargos);
        }

        // DELETE: api/Cargos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCargos(int id)
        {
            if (_context.Cargos == null)
            {
                return NotFound();
            }
            var cargos = await _context.Cargos.FindAsync(id);
            if (cargos == null)
            {
                return NotFound();
            }

            _context.Cargos.Remove(cargos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CargosExists(int id)
        {
            return (_context.Cargos?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
