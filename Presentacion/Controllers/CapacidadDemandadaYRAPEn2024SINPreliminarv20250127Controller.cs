using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.Query;
using PruebaTecnica.Dominio.Entidades;
using PruebaTecnica.Persistencia;

namespace Presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Controller : ControllerBase
    {
        private readonly AppDbContext _context;
        private IMediator _mediator;

        public CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Controller(AppDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        // GET: api/CapacidadDemandadaYRAPEn2024SINPreliminarv20250127
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127>>> GetCapacidadDemandadaYRAPEn2024SINPreliminarv20250127()
        {
            CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Query query = new();

            var res = await _mediator.Send(query);

            return res.resultado;
        }

        // GET: api/CapacidadDemandadaYRAPEn2024SINPreliminarv20250127/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127>> GetCapacidadDemandadaYRAPEn2024SINPreliminarv20250127(Guid id)
        {
            var capacidadDemandadaYRAPEn2024SINPreliminarv20250127 = await _context.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.FindAsync(id);

            if (capacidadDemandadaYRAPEn2024SINPreliminarv20250127 == null)
            {
                return NotFound();
            }

            return capacidadDemandadaYRAPEn2024SINPreliminarv20250127;
        }

        // PUT: api/CapacidadDemandadaYRAPEn2024SINPreliminarv20250127/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCapacidadDemandadaYRAPEn2024SINPreliminarv20250127(Guid id, CapacidadDemandadaYRAPEn2024SINPreliminarv20250127 capacidadDemandadaYRAPEn2024SINPreliminarv20250127)
        {
            if (id != capacidadDemandadaYRAPEn2024SINPreliminarv20250127.Id)
            {
                return BadRequest();
            }

            _context.Entry(capacidadDemandadaYRAPEn2024SINPreliminarv20250127).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Exists(id))
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

        // POST: api/CapacidadDemandadaYRAPEn2024SINPreliminarv20250127
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127>> PostCapacidadDemandadaYRAPEn2024SINPreliminarv20250127(CapacidadDemandadaYRAPEn2024SINPreliminarv20250127 capacidadDemandadaYRAPEn2024SINPreliminarv20250127)
        {
            _context.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.Add(capacidadDemandadaYRAPEn2024SINPreliminarv20250127);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCapacidadDemandadaYRAPEn2024SINPreliminarv20250127", new { id = capacidadDemandadaYRAPEn2024SINPreliminarv20250127.Id }, capacidadDemandadaYRAPEn2024SINPreliminarv20250127);
        }

        // DELETE: api/CapacidadDemandadaYRAPEn2024SINPreliminarv20250127/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCapacidadDemandadaYRAPEn2024SINPreliminarv20250127(Guid id)
        {
            var capacidadDemandadaYRAPEn2024SINPreliminarv20250127 = await _context.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.FindAsync(id);
            if (capacidadDemandadaYRAPEn2024SINPreliminarv20250127 == null)
            {
                return NotFound();
            }

            _context.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.Remove(capacidadDemandadaYRAPEn2024SINPreliminarv20250127);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Exists(Guid id)
        {
            return _context.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.Any(e => e.Id == id);
        }
    }
}
