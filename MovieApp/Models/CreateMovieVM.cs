using BLL.DTOs.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class CreateMovieVM
    {
        public CreateMovieDTO MovieModel { get; set; }

        public CreateMovieComponents Compenents { get; set; }
    }
}
