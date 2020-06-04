using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IMovieRepository : IRepositoryBase<Movie>
    {
        IEnumerable<Movie> GetAllMovieWithDirector();
    }
}
