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

namespace PCP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            //ConexionSQL xConexionSQL = new ConexionSQL("Data Source=mainpc\\mssql;Initial Catalog=solutiion;User ID=sa;");
            //string xCommandString = String.Format("select CG_CLI, DES_CLI, CG_COND, CUIT, CG_PROV from cliente");
            //DataTable clientes = xConexionSQL.EjecutarSQL(xCommandString);
            //List<Cliente> xList = clientes.AsEnumerable().Select(m => new Cliente()
            //{
            //    CG_CLI = m.Field<int>("CG_CLI"),
            //    DES_CLI = m.Field<string>("DES_CLI"),
            //    CG_COND = m.Field<string>("CG_COND"),
            //    CUIT = m.Field<string>("CUIT"),
            //    CG_PROV = m.Field<int>("CG_PROV"),
            //}).ToList();
            //return xList;

            var xitem = _context.Clientes.ToList();
            return xitem;
        }

        // GET: api/Clientes/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> Get(int id)
        {
            var xitem = await _context.Clientes.FindAsync(id);

            if (xitem == null)
            {
                return NotFound();
            }

            return xitem;
        }

        // PUT: api/Clientes/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Cliente xitem)
        {
            if (id != xitem.CG_CLI)
            {
                return BadRequest();
            }

            _context.Entry(xitem).State = EntityState.Modified;

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

        // POST: api/Clientes
        [HttpPost]
        public async Task<ActionResult<Cliente>> Post(Cliente xitem)
        {
            _context.Clientes.Add(xitem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = xitem.CG_CLI }, xitem);
        }

        // DELETE: api/Clientes/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cliente>> Delete(int id)
        {
            var xitem = await _context.Clientes.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Clientes.Any(e => e.CG_CLI == id);
        }
    }
}
