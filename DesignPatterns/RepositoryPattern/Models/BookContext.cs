namespace RepositoryPattern.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookContext() : base("DefaultConnection")
        {

        }
    }
}
