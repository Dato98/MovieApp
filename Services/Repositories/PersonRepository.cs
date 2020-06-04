using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository 
    {
        public PersonRepository(MovieDbContext context)
            : base(context)
        { }

        public IEnumerable<Person> GetDirectors()
        {
            return FindByCondition(x => x.IsDirector);
        }

        public Person GetPersonWithMovies(int id)
        {
            return Context.People.Where(x => x.Id == id).Include(x => x.Movies).FirstOrDefault();
        }
    }
}
