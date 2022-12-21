using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class AdvertisementConfiguration : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(200);
            builder.Property(x => x.Title).IsRequired();

            builder.Property(x => x.Description).HasColumnType("ntext");
            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getdate()");
        }
    }
}
