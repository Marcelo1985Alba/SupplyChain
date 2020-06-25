using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCP.Server.DataAccess;
using SupplyChain.Shared.Models;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PCP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : Controller
    {
        private int cg_cia_usuario = 1; /*CAMBIAR POR LA DEL USUARIO*/

        private readonly AppDbContext _context;
        public StockController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetMaxVale")]
        public async Task<IActionResult> GetMaxVale()
        {
            int numero = 1;
            if (await _context.Pedidos.CountAsync() > 0)
                numero += await _context.Pedidos.Where(p => p.CG_CIA == cg_cia_usuario).MaxAsync(p => (int)p.VALE);

            return Json(numero);
        }

        // GET:   
        [HttpGet("GetValesByTipo/{tipoo}")]
        public async Task<ActionResult<IEnumerable<Stock>>> GetValesByTipo(int tipoo)
        {
            List<Stock> lStock = new List<Stock>();
            if (_context.Pedidos.Any())
            {
                lStock = await _context.Pedidos.Where(p => p.TIPOO == tipoo && (int)p.VOUCHER == 0
                    && p.CG_CIA == cg_cia_usuario).ToListAsync();
            }

            if (lStock == null)
            {
                return NotFound();
            }

            return lStock;
        }

        // GET: api/Stock/AbriVale/{vale}
        [HttpGet("AbriVale/{vale}")]
        public async Task<ActionResult<List<Stock>>> AbriVale(int vale)
        {
            List<Stock> lStock = new List<Stock>();
            if (_context.Pedidos.Any())
            {
                lStock = await _context.Pedidos.Where(p => p.VALE == vale && p.CG_CIA == cg_cia_usuario).ToListAsync();
            }

            if (lStock == null)
            {
                return NotFound();
            }

            return lStock;
        }

        // PUT: api/Stock/PutStock/123729
        [HttpPut("PutStock/{registro}")]
        public async Task<ActionResult<Stock>> PutStock(decimal registro, Stock stock)
        {
            stock.USUARIO = "USER";
            stock.CG_CIA = 1;
            if (registro != stock.REGISTRO)
            {
                return BadRequest("Registro Incorrecto");
            }

            _context.Entry(stock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistroExists(registro))
                {
                    return NotFound();
                }
                else
                {
                    BadRequest();
                }
            }

            return Ok(stock);
        }

        //POST: api/Stock
        //To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Stock>> PostStock([FromBody] Stock stock)
        {
            stock.REGISTRO = null;
            stock.USUARIO = "USER";
            stock.CG_CIA = 1;
            stock.UNIDA = "Unid";
            //if (Stock?.CG_TIRE == 0  || 
            //    (Stock.CG_TIRE == 5 && Stock.CG_PROVE == 0) )
            //{
            //    return BadRequest();
            //}

            //if (Stock.CG_TIRE == 5 && Stock.CG_PROVE == 0)
            //{

            //}

            _context.Pedidos.Add(stock);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (RegistroExists(stock.REGISTRO))
                {
                    return Conflict();
                }
                else
                {
                    return BadRequest(ex);
                }
            }
            
            return Ok(stock);
        }

        private bool RegistroExists(decimal? registro)
        {
            return _context.Pedidos.Any(e => e.REGISTRO == registro);
        }
    }
}
