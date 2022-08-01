using RestWithASP_NETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASP_NETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

  

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IcrementAndGet(),
                FirstName = "Eduardo",
                LastName = "Murata",
                Address = "Rochdalle - Osasco - SP - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }    
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IcrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastNAme" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IcrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
