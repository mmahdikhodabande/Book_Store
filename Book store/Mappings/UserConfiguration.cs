using Book_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book_store.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.User_ID);

            builder.Property(x => x.FullName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(13);
            
            builder.HasMany(u => u.Carts)
                    .WithOne(u => u.User)
                    .HasForeignKey(u => u.User_ID)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Orders)
                    .WithOne(x => x.User)
                    .HasForeignKey(x => x.User_ID)
                    .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(x => x.reviews)
                    .WithOne(x => x.User)
                    .HasForeignKey(x => x.User_ID)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
