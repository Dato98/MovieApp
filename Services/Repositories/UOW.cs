using DAL.Context;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class UOW : IUOW
    {
        private MovieDbContext Context;
        private IMovieRepository movieRepository;
        private IPersonRepository personRepository;
        public UOW(MovieDbContext context)
        {
            Context = context;
        }

        public IMovieRepository Movie
        {
            get
            {
                if (movieRepository == null)
                    movieRepository = new MovieRepository(Context);
                return movieRepository;
            }
        }

        public IPersonRepository Person
        {
            get
            {
                if (personRepository == null)
                    personRepository = new PersonRepository(Context);
                return personRepository;
            }
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
