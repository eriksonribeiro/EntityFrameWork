using System.Data.Entity.ModelConfiguration;

namespace CodeFirstWorkFlow
{
    public class TagConfiguration:EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            Property(t => t.Name)
                  .IsRequired()
                  .HasMaxLength(255);
        }

    }
}
