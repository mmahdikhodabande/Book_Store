using Book_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book_store.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x=>x.Author_ID);

            builder.HasMany(x=>x.Books)
                    .WithOne(x=>x.Author)
                    .HasForeignKey(x=>x.Author_ID)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
