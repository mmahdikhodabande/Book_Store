using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string UserType { get; set; }
        public DateTime RegistratioDate { get; set; } = DateTime.Now;


        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> reviews { get; set; }





    }
}
