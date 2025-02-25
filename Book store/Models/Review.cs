using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class Review
    {
        [Key]
        public int Review_ID { get; set; }
        public int User_ID { get; set; }
        public User User { get; set; }
        public int Book_ID { get; set; }
        public Book Book { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.Now;    

    }
}