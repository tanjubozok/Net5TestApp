using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class AdvertisementAppUserStatusConfiguration : IEntityTypeConfiguration<AdvertisementAppUserStatus>
    {
        public void Configure(EntityTypeBuilder<AdvertisementAppUserStatus> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(300);
            builder.Property(x => x.Definition).IsRequired();

            builder.HasData(new AdvertisementAppUserStatus[]
            {
                new()
                {
                    Id= 1,
                    Definition="Başvurdu"
                },
                new()
                {
                    Id= 2,
                    Definition="Mülakata Çağrıldı"
                },
                new()
                {
                    Id= 3,
                    Definition="Olumlu Sonuçlandı"
                },
                new()
                {
                    Id= 4,
                    Definition="Olumsuz Sonuçlandı"
                }
            });
        }
    }
}
