using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Firstname).HasMaxLength(300);
            builder.Property(x => x.Firstname).IsRequired();

            builder.Property(x => x.Lastname).HasMaxLength(300);
            builder.Property(x => x.Lastname).IsRequired();

            builder.Property(x => x.Username).HasMaxLength(300);
            builder.Property(x => x.Username).IsRequired();

            builder.Property(x => x.Phone).HasMaxLength(20);
            builder.Property(x => x.Phone).IsRequired();

            builder.Property(x => x.Password).HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired();

            builder.HasOne(x => x.Gender).WithMany(x => x.AppUsers).HasForeignKey(x => x.GenderId);
        }
    }
}
