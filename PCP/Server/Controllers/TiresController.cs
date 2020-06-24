//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using PCP.Server.DataAccess;
//using PCP.Shared.Models;

//namespace PCP.Server.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TiresController : ControllerBase
//    {
//        private readonly AppDbContext _context;

//        public TiresController(/*AppDbContext context*/)
//        {
//            //_context = context;
//        }

//        // GET: api/Tires
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Tire>>> GetTire()
//        {
//            List<Tire> Tipos = new List<Tire>() {
//                new Tire() { Id = 1, Descrip = "Entrega y devolución de un insumo entregado a una orden de fabricación" },
//                new Tire() { Id = 2, Descrip = "Entrega de consumibles" },
//                new Tire() { Id = 3, Descrip = "Recepción y devolución de un insumo de un proveedor para una orden de compra" },
//                new Tire() { Id = 4, Descrip = "Envío y recuperación de un insumo y producto a y de scrap" },
//                new Tire() { Id = 5, Descrip = "Movimientos entre depósitos" },
//                new Tire() { Id = 6, Descrip = "Entrega y devolución a un cliente con y sin pedido" }
//            };

//            return await _context.Tire.ToListAsync();
//            //return await Task<Tipos>;
//        }

//        // GET: api/Tires/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Tire>> GetTire(int id)
//        {
//            var tire = await _context.Tire.FindAsync(id);

//            if (tire == null)
//            {
//                return NotFound();
//            }

//            return tire;
//        }

//        // PUT: api/Tires/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutTire(int id, Tire tire)
//        {
//            if (id != tire.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(tire).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!TireExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Tires
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPost]
//        public async Task<ActionResult<Tire>> PostTire(Tire tire)
//        {
//            _context.Tire.Add(tire);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetTire", new { id = tire.Id }, tire);
//        }

//        // DELETE: api/Tires/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<Tire>> DeleteTire(int id)
//        {
//            var tire = await _context.Tire.FindAsync(id);
//            if (tire == null)
//            {
//                return NotFound();
//            }

//            _context.Tire.Remove(tire);
//            await _context.SaveChangesAsync();

//            return tire;
//        }

//        private bool TireExists(int id)
//        {
//            return _context.Tire.Any(e => e.Id == id);
//        }
//    }
//}
