using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly SchoolContext _dbContext;

        public StudentsController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET 
        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
           return Ok(_dbContext.Student.Include(s => s.Id).ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _dbContext.Student
                .SingleOrDefault(s => s.Id == id);

            if (student != null) {
                return student;
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Student> AddProduct(Student student)
        {
            _dbContext.Student.Add(student);
            _dbContext.SaveChanges();

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            var student = new Student { Id = id };

            _dbContext.Student.Attach(student);
            _dbContext.Student.Remove(student);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id, Student studentUpdate)
        {
            var student = _dbContext.Student
                .SingleOrDefault(s => s.Id == id);

            if (student != null)
            {
                student.Person = studentUpdate.Person;
                student.PersonId = studentUpdate.PersonId;
                student.StudentID = studentUpdate.StudentID;
                student.Email = studentUpdate.Email;

                _dbContext.Update(student);

                _dbContext.SaveChanges();
            }

            return NoContent();
        }
    }
}
