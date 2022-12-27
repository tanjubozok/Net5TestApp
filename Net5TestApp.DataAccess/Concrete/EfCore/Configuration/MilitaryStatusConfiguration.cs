using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class MilitaryStatusConfiguration : IEntityTypeConfiguration<MilitaryStatus>
    {
        public void Configure(EntityTypeBuilder<MilitaryStatus> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(300);
            builder.Property(x => x.Definition).IsRequired();

            builder.HasData(new MilitaryStatus[]
            {
                new()
                {
                    Id= 1,
                    Definition="Yaptı"
                },
                new()
                {
                    Id= 2,
                    Definition="Tecilli"
                },
                new()
                {
                    Id= 3,
                    Definition="Muaf"
                }
            });
        }
    }
}
