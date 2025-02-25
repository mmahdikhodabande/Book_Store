using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class Payment
    {
        [Key]
        public int Paryment_ID { get; set; }
        public int Order_ID { get; set; }
        public Order Order { get; set; }
        public int Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; } = "Pending";
        public DateTime PaymentDate { get; set; } = DateTime.Now;

    }
}
