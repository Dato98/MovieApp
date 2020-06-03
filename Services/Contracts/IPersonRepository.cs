using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        Person GetPersonWithMovies(int id);
    }
}
