using Book_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book_store.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Book_ID);

            //builder.HasOne(x => x.Author)
            //        .WithMany(x => x.Books)
            //        .HasForeignKey(x => x.Author_ID)
            //        .OnDelete(DeleteBehavior.Cascade);

            //builder.HasOne(x => x.Publisher)
            //        .WithMany(x => x.Books)
            //        .HasForeignKey(x => x.Publisher_ID)
            //        .OnDelete(DeleteBehavior.Cascade);

            //builder.HasOne(x => x.Publisher)
            //        .WithMany(x => x.Books)
            //        .HasForeignKey(x => x.Publisher_ID)
            //        .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.BookCategories)
                    .WithOne(x => x.Book)
                    .HasForeignKey(x => x.Book_ID)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.CartItems)
                    .WithOne(x => x.Book)
                    .HasForeignKey(x => x.CartItem_ID)
                    .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(x => x.OrderItems)
                    .WithOne(x => x.Book)
                    .HasForeignKey(x => x.OrderItem_ID)
                    .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(x => x.Reviews)
                    .WithOne(x => x.Book)
                    .HasForeignKey(x => x.Review_ID)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
