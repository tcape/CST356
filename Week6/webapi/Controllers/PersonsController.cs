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
    public class PersonsController : ControllerBase
    {

        private readonly SchoolContext _dbContext;

        public PersonsController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET 
        [HttpGet]
        public ActionResult<List<Person>> GetAllPersons()
        {
           return Ok(_dbContext.Person.Include(p => p.Id).ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<Person> GetPerson(int id)
        {
            var person = _dbContext.Person
                .SingleOrDefault(p => p.Id == id);

            if (person != null) {
                return person;
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Person> AddPerson(Person person)
        {
            _dbContext.Person.Add(person);
            _dbContext.SaveChanges();

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePerson(int id)
        {
            var person = new Person { Id = id };

            _dbContext.Person.Attach(person);
            _dbContext.Person.Remove(person);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePerson(int id, Person personUpdate)
        {
            var person = _dbContext.Person
                .SingleOrDefault(p => p.Id == id);

            if (person != null)
            {
                person.FirstName = personUpdate.FirstName;
                person.MidInitial = personUpdate.MidInitial;
                person.LastName = personUpdate.LastName;
                person.Student = personUpdate.Student;

                _dbContext.Update(person);

                _dbContext.SaveChanges();
            }

            return NoContent();
        }
       
    }
}
