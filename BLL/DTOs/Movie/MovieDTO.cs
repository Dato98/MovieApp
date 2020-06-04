using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Movie
{
    public class MovieDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public int DirectorId { get; set; }
    }
}
