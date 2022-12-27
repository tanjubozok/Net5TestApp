using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class AppUserRoleConfiguration : IEntityTypeConfiguration<AppUserRoles>
    {
        public void Configure(EntityTypeBuilder<AppUserRoles> builder)
        {
            builder.HasIndex(x => new
            {
                x.AppRoleId,
                x.AppUserId
            }).IsUnique();

            builder.HasOne(x => x.AppRole).WithMany(x => x.AppUserRoles).HasForeignKey(x => x.AppRoleId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUserRoles).HasForeignKey(x => x.AppUserId);

            builder.HasData(new AppUserRoles[]
            {
                new()
                {
                    Id= 1,
                    AppUserId= 1,
                    AppRoleId=1
                },
                new()
                {   Id=2,
                    AppUserId= 2,
                    AppRoleId=2
                }
            });
        }
    }
}
