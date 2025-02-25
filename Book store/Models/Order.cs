using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class Order
    {
        [Key]
        public int Order_ID { get; set; }
        public int User_ID { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public ICollection<OrderItem> OrderItems { get; set; }
        public Payment Payment { get; set; }
    }
}