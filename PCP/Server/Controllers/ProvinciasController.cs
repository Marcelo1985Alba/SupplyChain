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
    public class ProvinciasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProvinciasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Provincias
        [HttpGet]
        public IEnumerable<Provincia> Get()
        {
            var xLista = _context.Provincias.ToList();
            return xLista;
        }

        // GET: api/Provincias/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Provincia>> Get(int id)
        {
            var xItem = await _context.Provincias.FindAsync(id);

            if (xItem == null)
            {
                return NotFound();
            }

            return xItem;
        }

        // PUT: api/Provincias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Provincia xItem)
        {
            if (id != xItem.CG_PROV)
            {
                return BadRequest();
            }

            _context.Entry(xItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Existe(id))
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

        // POST: api/Provincia
        [HttpPost]
        public async Task<ActionResult<Provincia>> Post(Provincia xItem)
        {
            _context.Provincias.Add(xItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = xItem.CG_PROV }, xItem);
        }

        // DELETE: api/Provincias/id
        [HttpDelete("{id}")]
        public async Task<ActionResult<Provincia>> Delete(int id)
        {
            var xItem = await _context.Provincias.FindAsync(id);
            if (xItem == null)
            {
                return NotFound();
            }

            _context.Provincias.Remove(xItem);
            await _context.SaveChangesAsync();

            return xItem;
        }

        private bool Existe(int id)
        {
            return _context.Provincias.Any(e => e.CG_PROV == id);
        }
    }
}
