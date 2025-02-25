using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class Cart
    {
        [Key]
        public int Cart_ID { get; set; }
        public int User_ID { get; set; }
        public User User { get; set; }
        public string Status { get; set; } = "Open";
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<CartItem> CartItems { get; set; }
    }
}