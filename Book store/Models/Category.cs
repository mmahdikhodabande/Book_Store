using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class Category
    {
        [Key]
        public int Catregory_ID { get; set; }
        public string Name { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }   
    }
}