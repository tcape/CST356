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
       
    }
}
