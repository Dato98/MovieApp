using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository 
    {
        public MovieRepository(MovieDbContext context)
            : base(context)
        { }

        public IEnumerable<Movie> GetAllMovieWithDirector()
        {
            return Context.Movies.Include(x => x.Director);
        }
    }
}
