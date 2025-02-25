using Book_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book_store.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x=>x.Cart_ID);

            //builder.HasOne(x => x.User)
            //        .WithMany(x=>x.Carts)
            //        .HasForeignKey(x=>x.User_ID)
            //        .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.CartItems)
                    .WithOne(x => x.Cart)
                    .HasForeignKey(x => x.Cart_ID)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
