using System;
using System.Collections.Generic;

namespace CodeFirstWorkFlow
{
    public class Genre
    {
        public byte Id { get; set; }
        public String Name { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}
