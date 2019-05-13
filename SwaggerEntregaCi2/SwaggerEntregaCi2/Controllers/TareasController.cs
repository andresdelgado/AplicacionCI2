using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwaggerEntregaCi2.Models;

namespace SwaggerEntregaCi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly TareaContext _context;

        public TareasController(TareaContext context)
        {
            _context = context;
        }

        // GET: api/Tareas
        [HttpGet("consultarTareas")]
        public async Task<ActionResult<IEnumerable<Tarea>>> GetTarea()
        {
            var totalTareas = _context.tarea.Include(t => t.autor);
            return await totalTareas.ToListAsync();
            //return await _context.tarea.ToListAsync();
        }

        // GET: api/Tareas/id
        [HttpGet("consultarId/{id}")]
        public async Task<ActionResult<Tarea>> GetTareaId(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //var tarea = await _context.tarea.FindAsync(id);
            var tarea = await _context.tarea.Include(t => t.autor).FirstOrDefaultAsync(m => m.idtarea == id);
            if (tarea == null)
            {
                return NotFound();
            }
            return tarea;
        }

        // GET: api/Tareas/estado
        [HttpGet("consultarEstado/{estado}")]
        public async Task<ActionResult<Tarea>> GetTareaEstado(string estado)
        {
            if (estado != null)
            {
                var taestadosi = await _context.tarea.Include(t => t.autor).FirstOrDefaultAsync(e => e.estado == estado);
                string x = "si";
                var taestadono = await _context.tarea.Include(t => t.autor).FirstOrDefaultAsync(e => e.estado == estado);
                string y = "no";
                try
                {
                    if (estado == x)
                    {
                        return taestadosi;
                    }
                    if (estado == y)
                    {
                        return taestadono;
                    }
                }
                catch (Exception)
                {
                    return NotFound();
                }
            }
            return NotFound();
        }

        // PUT: api/Tareas/5
        [HttpPut("actualizar/{id}")]
        public async Task<IActionResult> PutTarea(int id, Tarea tarea)
        {
            if (id != tarea.idtarea)
            {
                return BadRequest();
            }

            _context.Entry(tarea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TareaExists(id))
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

        // POST: api/Tareas
        [HttpPost("crear")]
        public async Task<ActionResult<Tarea>> PostTarea(Tarea tarea)
        {
            _context.tarea.Add(tarea);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTareaId", new { id = tarea.idtarea }, tarea);
        }

        // DELETE: api/Tareas/5
        [HttpDelete("borrar/{id}")]
        public async Task<ActionResult<Tarea>> DeleteTarea(int id)
        {
            var tarea = await _context.tarea.FindAsync(id);
            if (tarea == null)
            {
                return NotFound();
            }

            _context.tarea.Remove(tarea);
            await _context.SaveChangesAsync();

            return tarea;
        }

        private bool TareaExists(int id)
        {
            return _context.tarea.Any(e => e.idtarea == id);
        }
    }
}
