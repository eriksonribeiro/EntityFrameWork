using System.Data.Entity.ModelConfiguration;

namespace CodeFirstWorkFlow
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(g => g.Genre)
                .WithMany(v => v.Videos)
                .HasForeignKey(g => g.GenreId);

            HasMany(t => t.Tags)
                .WithMany(v => v.Videos)
                .Map(m =>
                {
                    m.ToTable("VideosTags");
                    m.MapLeftKey("VideoId");
                    m.MapRightKey("TagId");
                });
        }
    }
}
