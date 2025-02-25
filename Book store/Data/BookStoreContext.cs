using Book_store.Configurations;
using Book_store.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_store.Data
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }



        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }


        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookStoreContext).Assembly);
            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderConfiguration());
            //modelBuilder.ApplyConfiguration(new CartConfiguration());

            //modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            //modelBuilder.ApplyConfiguration(new BookConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            //modelBuilder.ApplyConfiguration(new PublisherConfiguration());
        }
    }
}
