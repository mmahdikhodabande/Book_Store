using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class Author
    {
        [Key]
        public int Author_ID { get; set; }
        public string Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}