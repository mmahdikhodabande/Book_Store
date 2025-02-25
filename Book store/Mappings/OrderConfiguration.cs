using Book_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book_store.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Order_ID);

            builder.HasMany(x => x.OrderItems)
                    .WithOne(x => x.Order)
                    .HasForeignKey(x => x.OrderItem_ID)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Payment)
                    .WithOne(x => x.Order)
                    .HasForeignKey<Payment>(x => x.Paryment_ID);
                


        }
    }
}
