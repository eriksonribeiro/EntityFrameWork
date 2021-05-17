using System.Data.Entity;

namespace CodeFirstWorkFlow
{
    public class VidzyContext : DbContext
    { 
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VidzyContext()
            :base("name=DefaultConnection")
        {
        }
    }
}
