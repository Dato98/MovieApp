using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Movie
{
    public class CreateMovieComponents
    {
        public List<SelectListItem> DirectorList { get; set; }
    }
}
