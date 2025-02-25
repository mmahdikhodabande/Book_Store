using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class BookCategory
    {
        [Key]
        public int Book_ID { get; set; }
        public Book Book { get; set; }
        public int Category_ID { get; set; }
        public Category Category_Book { get; set; }

    }
}   