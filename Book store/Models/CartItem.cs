using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class CartItem
    {
        [Key]
        public int CartItem_ID { get; set; }
        public int Cart_ID { get; set; }
        public Cart Cart { get; set; }
        public int Book_ID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}
