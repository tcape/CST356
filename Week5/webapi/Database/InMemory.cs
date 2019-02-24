using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Person> persons = new List<Person> {
            new Person {
                Id = 1,
                FirstName = "Tim",
                MiddleInitial = 'M',
                LastName = "Capehart"
            },
            new Person {
                Id = 2,
                FirstName = "Bob",
                MiddleInitial = 'M',
                LastName = "Smith"
            },
        };

        public static List<Student> students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = 123456,
                Email = "bob@gmail.com"
            },
           new Student {
                Id = 2,
                StudentId = 8450943,
                Email = "joe@gmail.com"
            },
        };
    }
}