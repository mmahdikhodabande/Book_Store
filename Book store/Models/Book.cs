using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class Book
    {
        [Key]
        public int Book_ID { get; set; }
        public string Title { get; set; }
        public int? Author_ID { get; set; }
        public Author?  Author { get; set; }
        public int? Publisher_ID { get; set; }
        public Publisher? Publisher { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public DateTime? PublishDate { get; set; }
        public string? Cover_Image { get; set; }
        public int? PageCount { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
        public ICollection<Review>? Reviews { get; set; }
            
    }
}
//dotnet aspnet-codegenerator controller -name PublisherController -m Publisher -dc BookStoreContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --project "Book store.csproj"