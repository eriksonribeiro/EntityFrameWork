using System.Data.Entity;

namespace CodeFirstWorkFlow
{
    public class VidzyContext : DbContext
    { 
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public VidzyContext()
            :base("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
