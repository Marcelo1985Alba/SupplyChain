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
    public class ResumenStocksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ResumenStocksController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ResumenStocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResumenStock>>> GetResumenStock()
        {
            try
            {
                return await _context.ResumenStock.ToListAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET: api/ResumenStocksGetResumenStockByDeposito/1
        [HttpGet("GetResumenStockByDeposito/{cg_dep}")]
        public async Task<ActionResult<IEnumerable<ResumenStock>>> GetResumenStockByDeposito(int cg_dep)
        {
            return await _context.ResumenStock.Where(r=> r.CG_DEP == cg_dep).ToListAsync();
        }

        // GET: api/ResumenStocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResumenStock>> GetResumenStock(decimal id)
        {
            var resumenStock = await _context.ResumenStock.FindAsync(id);

            if (resumenStock == null)
            {
                return NotFound();
            }

            return resumenStock;
        }

        // PUT: api/ResumenStocks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResumenStock(decimal id, ResumenStock resumenStock)
        {
            if (id != resumenStock.Registro)
            {
                return BadRequest();
            }

            _context.Entry(resumenStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResumenStockExists(id))
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

        // POST: api/ResumenStocks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ResumenStock>> PostResumenStock(ResumenStock resumenStock)
        {
            _context.ResumenStock.Add(resumenStock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResumenStock", new { id = resumenStock.Registro }, resumenStock);
        }

        // DELETE: api/ResumenStocks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ResumenStock>> DeleteResumenStock(decimal id)
        {
            var resumenStock = await _context.ResumenStock.FindAsync(id);
            if (resumenStock == null)
            {
                return NotFound();
            }

            _context.ResumenStock.Remove(resumenStock);
            await _context.SaveChangesAsync();

            return resumenStock;
        }

        private bool ResumenStockExists(decimal id)
        {
            return _context.ResumenStock.Any(e => e.Registro == id);
        }
    }
}
