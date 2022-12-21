using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class ProvidedServiceConfiguration : IEntityTypeConfiguration<ProvidedService>
    {
        public void Configure(EntityTypeBuilder<ProvidedService> builder)
        {
            builder.Property(x => x.Description).HasColumnType("ntext");
            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.ImagePath).HasMaxLength(500);
            builder.Property(x => x.ImagePath).IsRequired();

            builder.Property(x => x.Title).HasMaxLength(300);
            builder.Property(x => x.Title).IsRequired();

            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getdate()");
        }
    }
}
