using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCP.Server.DataAccess;
using SupplyChain.Shared.Models;

namespace PCP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramasController : ControllerBase
    {
        private readonly AppDbContext _context;
        private int cg_cia_usuario = 1; /*CAMBIAR POR LA DEL USUARIO*/

        public ProgramasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Programas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Programa>>> GetProgramas()
        {
            try
            {
                return await _context.Programas.Where(p => p.Cg_Cia == cg_cia_usuario).ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        // GET: api/Programas/GetProgramaByOF/cg_ordf
        [HttpGet("GetProgramaByOF/{cg_ordf}")]
        public async Task<ActionResult<IEnumerable<Programa>>> GetCompraByOF(decimal cg_ordf)
        {
            try
            {
                return await _context.Programas.Where(p => p.Cg_Cia == cg_cia_usuario 
                    && p.CG_ORDF == cg_ordf).ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        // GET: api/Programas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Programa>> GetPrograma(decimal id)
        {
            var programa = await _context.Programas.FindAsync(id);

            if (programa == null)
            {
                return NotFound();
            }

            return programa;
        }

        // PUT: api/Programas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrograma(decimal id, Programa programa)
        {
            if (id != programa.REGISTRO)
            {
                return BadRequest();
            }

            _context.Entry(programa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramaExists(id))
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

        // POST: api/Programas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Programa>> PostPrograma(Programa programa)
        {
            _context.Programas.Add(programa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrograma", new { id = programa.REGISTRO }, programa);
        }

        // DELETE: api/Programas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Programa>> DeletePrograma(decimal id)
        {
            var programa = await _context.Programas.FindAsync(id);
            if (programa == null)
            {
                return NotFound();
            }

            _context.Programas.Remove(programa);
            await _context.SaveChangesAsync();

            return programa;
        }

        private bool ProgramaExists(decimal id)
        {
            return _context.Programas.Any(e => e.REGISTRO == id);
        }
    }
}
