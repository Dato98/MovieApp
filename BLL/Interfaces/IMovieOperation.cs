using BLL.DTOs.Movie;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IMovieOperation
    {
        IEnumerable<MovieDTO> GetAll();

        CreateMovieComponents GetCreateMovieComponents();

        void Create(CreateMovieDTO model);

        EditMovieDTO GetEditMovieData(int id);

        void Edit(EditMovieDTO model);
    }
}
