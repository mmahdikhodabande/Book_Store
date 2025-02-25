using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class Publisher
    {
        [Key]
        public int Publisher_ID { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}