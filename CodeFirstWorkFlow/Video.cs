using System;
using System.Dynamic;

namespace CodeFirstWorkFlow
{
    public class Video
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte GenreId { get; set; }
        public byte Classification { get; set; }
    }
}
