using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItem_ID { get; set; }
        public int Order_ID { get; set; }
        public Order Order { get; set; }
        public int Book_ID { get; set; }
        public Book Book { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }

    }
}