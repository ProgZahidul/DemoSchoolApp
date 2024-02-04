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
    [Authorize]
    public class AdmissionsController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public AdmissionsController(SchoolDbContext context)
        {
            _context = context;
        }


        // GET: api/Admissions
        [HttpGet]
        public IActionResult GetAllAdmissions()
        {
            try
            {
                var admissions = _context.dbsAdmission
                    .Include(a => a.Student)
                    .Include(a => a.AcademicYear)
                    .Include(a => a.Student.Parents)
                    .Include(a => a.Student.Class)
                    .ToList();

                return Ok(admissions);
            }
            catch (Exception ex)
            {
                // Log the exception or return an error response with details
                var errorMessage = "An error occurred while retrieving admissions.";

                // For simplicity, returning a BadRequest with the error message
                return BadRequest(errorMessage);
            }
        }

        // GET: api/Admissions/5
        [HttpGet("{id}")]
        public IActionResult GetAdmissionById(int id)
        {
            try
            {
                var admission = _context.dbsAdmission
                    .Include(a => a.Student)
                    .Include(a => a.AcademicYear)
                    .Include(a => a.Student.Parents)
                    .Include(a => a.Student.Class)
                    .FirstOrDefault(a => a.AdmissionId == id);

                if (admission == null)
                {
                    return NotFound($"Admission with ID {id} not found");
                }

                return Ok(admission);
            }
            catch (Exception ex)
            {
                // Log the exception or return an error response with details
                var errorMessage = $"An error occurred while retrieving admission with ID {id}.";

                // For simplicity, returning a BadRequest with the error message
                return BadRequest(errorMessage);
            }
        }

        // POST: api/Admissions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Admission>> PostAdmission(Admission admission)
        {
            _context.dbsAdmission.Add(admission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdmissionById", new { id = admission.AdmissionId }, admission);
        }

        // DELETE: api/Admissions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmission(int id)
        {
            var admission = await _context.dbsAdmission.FindAsync(id);
            if (admission == null)
            {
                return NotFound();
            }

            _context.dbsAdmission.Remove(admission);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdmissionExists(int id)
        {
            return _context.dbsAdmission.Any(e => e.AdmissionId == id);
        }
    }
}
