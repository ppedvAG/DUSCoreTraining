using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DUSCoreTraining.Models;
using Microsoft.AspNetCore.Authorization;

namespace DUSCoreTraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class RechnungsController : ControllerBase
    {
        private readonly ModelRechnung _context;

        public RechnungsController(ModelRechnung context)
        {
            _context = context;
        }

        // GET: api/Rechnungs
       
        public async Task<ActionResult<IEnumerable<Rechnung>>> GetRechnungs()
        {
            return await _context.Rechnungs.Take(10).ToListAsync();
        }

        // GET: api/Rechnungs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rechnung>> GetRechnung(int id)
        {
            var rechnung = await _context.Rechnungs.FindAsync(id);

            if (rechnung == null)
            {
                return NoContent(); //NoFound
            }

            return rechnung;
        }

        // PUT: api/Rechnungs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRechnung(int id, Rechnung rechnung)
        {
            if (id != rechnung.ID)
            {
                return BadRequest();
            }

            _context.Entry(rechnung).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RechnungExists(id))
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

        // POST: api/Rechnungs
        [HttpPost]
        public async Task<ActionResult<Rechnung>> PostRechnung(Rechnung rechnung)
        {
            _context.Rechnungs.Add(rechnung);
            await _context.SaveChangesAsync();
           
            return CreatedAtAction("GetRechnung", new { id = rechnung.ID }, rechnung);
        }

        // DELETE: api/Rechnungs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rechnung>> DeleteRechnung(int id)
        {
            var rechnung = await _context.Rechnungs.FindAsync(id);
            if (rechnung == null)
            {
                return NotFound();
            }

            _context.Rechnungs.Remove(rechnung);
            await _context.SaveChangesAsync();

            return rechnung;
        }

        private bool RechnungExists(int id)
        {
            return _context.Rechnungs.Any(e => e.ID == id);
        }
    }
}
