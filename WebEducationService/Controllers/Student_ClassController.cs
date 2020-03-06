using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEducationService.Data;
using WebEducationService.Models;

namespace WebEducationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Student_ClassController : ControllerBase
    {
        private readonly EdDbContext _context;

        public Student_ClassController(EdDbContext context)
        {
            _context = context;
        }

        // GET: api/Student_Class
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student_Class>>> GetStudent_Class()
        {
            return await _context.Student_Class.ToListAsync();
        }

        // GET: api/Student_Class/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student_Class>> GetStudent_Class(int id)
        {
            var student_Class = await _context.Student_Class.FindAsync(id);

            if (student_Class == null)
            {
                return NotFound();
            }

            return student_Class;
        }

        // PUT: api/Student_Class/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent_Class(int id, Student_Class student_Class)
        {
            if (id != student_Class.Id)
            {
                return BadRequest();
            }

            _context.Entry(student_Class).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Student_ClassExists(id))
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

        // POST: api/Student_Class
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Student_Class>> PostStudent_Class(Student_Class student_Class)
        {
            _context.Student_Class.Add(student_Class);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent_Class", new { id = student_Class.Id }, student_Class);
        }

        // DELETE: api/Student_Class/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Student_Class>> DeleteStudent_Class(int id)
        {
            var student_Class = await _context.Student_Class.FindAsync(id);
            if (student_Class == null)
            {
                return NotFound();
            }

            _context.Student_Class.Remove(student_Class);
            await _context.SaveChangesAsync();

            return student_Class;
        }

        private bool Student_ClassExists(int id)
        {
            return _context.Student_Class.Any(e => e.Id == id);
        }
    }
}
