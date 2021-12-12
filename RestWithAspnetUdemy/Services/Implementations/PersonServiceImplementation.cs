using RestWithAspnetUdemy.Model;
using RestWithAspnetUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithAspnetUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private DataContext _context;

        public PersonServiceImplementation(DataContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindByID(long id)
        {
            return null;
        }

        public Person Update(Person person)
        {
            return person;
        }

    }
}
