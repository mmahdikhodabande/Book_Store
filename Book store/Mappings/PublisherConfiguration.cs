using Book_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book_store.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(x=> x.Publisher_ID);

            builder.HasMany(x=>x.Books)
                    .WithOne(x => x.Publisher)
                    .HasForeignKey(x=>x.Publisher_ID)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
