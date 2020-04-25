using System;
using System.Collections.Generic;
using System.Dynamic;

namespace CodeFirstWorkFlow
{
    public class Video
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte GenreId { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification { get; set; }
        public ICollection<Tag> Tags { get; set; }

    }

}
