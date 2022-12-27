using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Firstname).HasMaxLength(128);
            builder.Property(x => x.Firstname).IsRequired();

            builder.Property(x => x.Lastname).HasMaxLength(128);
            builder.Property(x => x.Lastname).IsRequired();

            builder.Property(x => x.Username).HasMaxLength(128);
            builder.Property(x => x.Username).IsRequired();

            builder.Property(x => x.Phone).HasMaxLength(20);
            builder.Property(x => x.Phone).IsRequired();

            builder.Property(x => x.Password).HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired();

            builder.HasOne(x => x.Gender).WithMany(x => x.AppUsers).HasForeignKey(x => x.GenderId);

            builder.HasData(new AppUser[]
            {
                new()
                {
                    Id=1,
                    Firstname="Admin",
                    Lastname="Guest",
                    Username="admin",
                    Password="123456",
                    Phone="12345678",
                    GenderId=1
                },
                new()
                {
                    Id=2,
                    Firstname="User",
                    Lastname="Guest",
                    Username="user",
                    Password="123456",
                    Phone="12345678",
                    GenderId=2
                }
            });
        }
    }
}
