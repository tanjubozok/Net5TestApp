using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(300);
            builder.Property(x => x.Definition).IsRequired();

            builder.HasData(new AppRole[]
            {
                new()
                {
                    Id=1,
                    Definition="Admin",
                },
                new()
                {
                    Id=2,
                    Definition= "Member",
                }
            });
        }
    }
}
