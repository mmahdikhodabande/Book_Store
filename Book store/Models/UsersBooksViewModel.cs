namespace Book_store.Models
{
    public class UsersBooksViewModel
    {
        public PaginationModel<User> Users { get; set; }
        public List<Book> Books { get; set; }
    }

}
