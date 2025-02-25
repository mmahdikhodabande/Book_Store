using Book_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book_store.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x=>x.Catregory_ID);


            builder.HasMany(x => x.BookCategories)
                    .WithOne(x => x.Category_Book)
                    .HasForeignKey(x => x.Category_ID)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
