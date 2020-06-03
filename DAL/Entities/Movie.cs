using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public int DirectorId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Person Director { get; set; }

        public ICollection<MovieActors> MovieActors { get; set; }
    }
}
