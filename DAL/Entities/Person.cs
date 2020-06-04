using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Person
    {
        public int Id { get;set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public bool IsDirector { get; set; }

        public bool IsActor { get; set; }

        public ICollection<Movie> Movies { get; set; }

        public ICollection<MovieActors> MovieActors { get; set; }
    }
}
