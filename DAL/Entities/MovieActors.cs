using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class MovieActors
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int PersonId { get; set; }

        public Person Actor { get; set; }

        public Movie Movie { get; set; }
    }
}
