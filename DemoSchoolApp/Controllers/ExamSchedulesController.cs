using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoSchoolApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace DemoSchoolApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize()]
    public class ExamSchedulesController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public ExamSchedulesController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: api/ExamSchedules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExamSchedule>>> GetdbsExamSchedule()
        {
            return await _context.dbsExamSchedule.ToListAsync();
        }

        // GET: api/ExamSchedules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExamSchedule>> GetExamSchedule(int id)
        {
            var examSchedule = await _context.dbsExamSchedule.FindAsync(id);

            if (examSchedule == null)
            {
                return NotFound();
            }

            return examSchedule;
        }

        // PUT: api/ExamSchedules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExamSchedule(int id, ExamSchedule examSchedule)
        {
            if (id != examSchedule.ExamScheduleId)
            {
                return BadRequest();
            }

            _context.Entry(examSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExamScheduleExists(id))
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

        // POST: api/ExamSchedules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExamSchedule>> PostExamSchedule(ExamSchedule examSchedule)
        {
            _context.dbsExamSchedule.Add(examSchedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExamSchedule", new { id = examSchedule.ExamScheduleId }, examSchedule);
        }

        // DELETE: api/ExamSchedules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExamSchedule(int id)
        {
            var examSchedule = await _context.dbsExamSchedule.FindAsync(id);
            if (examSchedule == null)
            {
                return NotFound();
            }

            _context.dbsExamSchedule.Remove(examSchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExamScheduleExists(int id)
        {
            return _context.dbsExamSchedule.Any(e => e.ExamScheduleId == id);
        }
    }
}
