using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINv20250131.Query;
using PruebaTecnica.Dominio.Entidades;
using PruebaTecnica.Persistencia;

namespace Presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapacidadDemandadaYRAPEn2024SINv20250131Controller : ControllerBase
    {
        private readonly AppDbContext _context;
        private IMediator _mediator;

        public CapacidadDemandadaYRAPEn2024SINv20250131Controller(AppDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        // GET: api/CapacidadDemandadaYRAPEn2024SINv20250131
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CapacidadDemandadaYRAPEn2024SINv20250131>>> GetCapacidadDemandadaYRAPEn2024SINv20250131()
        {
            CapacidadDemandadaYRAPEn2024SINv20250131Query query = new();

            var res = await _mediator.Send(query);

            return res.resultado;
        }

        // GET: api/CapacidadDemandadaYRAPEn2024SINv20250131/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CapacidadDemandadaYRAPEn2024SINv20250131>> GetCapacidadDemandadaYRAPEn2024SINv20250131(Guid id)
        {
            var capacidadDemandadaYRAPEn2024SINv20250131 = await _context.CapacidadDemandadaYRAPEn2024SINv20250131.FindAsync(id);

            if (capacidadDemandadaYRAPEn2024SINv20250131 == null)
            {
                return NotFound();
            }

            return capacidadDemandadaYRAPEn2024SINv20250131;
        }

        // PUT: api/CapacidadDemandadaYRAPEn2024SINv20250131/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCapacidadDemandadaYRAPEn2024SINv20250131(Guid id, CapacidadDemandadaYRAPEn2024SINv20250131 capacidadDemandadaYRAPEn2024SINv20250131)
        {
            if (id != capacidadDemandadaYRAPEn2024SINv20250131.Id)
            {
                return BadRequest();
            }

            _context.Entry(capacidadDemandadaYRAPEn2024SINv20250131).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CapacidadDemandadaYRAPEn2024SINv20250131Exists(id))
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

        // POST: api/CapacidadDemandadaYRAPEn2024SINv20250131
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CapacidadDemandadaYRAPEn2024SINv20250131>> PostCapacidadDemandadaYRAPEn2024SINv20250131(CapacidadDemandadaYRAPEn2024SINv20250131 capacidadDemandadaYRAPEn2024SINv20250131)
        {
            _context.CapacidadDemandadaYRAPEn2024SINv20250131.Add(capacidadDemandadaYRAPEn2024SINv20250131);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCapacidadDemandadaYRAPEn2024SINv20250131", new { id = capacidadDemandadaYRAPEn2024SINv20250131.Id }, capacidadDemandadaYRAPEn2024SINv20250131);
        }

        // DELETE: api/CapacidadDemandadaYRAPEn2024SINv20250131/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCapacidadDemandadaYRAPEn2024SINv20250131(Guid id)
        {
            var capacidadDemandadaYRAPEn2024SINv20250131 = await _context.CapacidadDemandadaYRAPEn2024SINv20250131.FindAsync(id);
            if (capacidadDemandadaYRAPEn2024SINv20250131 == null)
            {
                return NotFound();
            }

            _context.CapacidadDemandadaYRAPEn2024SINv20250131.Remove(capacidadDemandadaYRAPEn2024SINv20250131);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CapacidadDemandadaYRAPEn2024SINv20250131Exists(Guid id)
        {
            return _context.CapacidadDemandadaYRAPEn2024SINv20250131.Any(e => e.Id == id);
        }
    }
}
