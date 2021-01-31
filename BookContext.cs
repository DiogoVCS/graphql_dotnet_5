using Microsoft.EntityFrameworkCore;

namespace GraphQl
{
    public class BookContext : DbContext
    {

        public BookContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Book> Books { get; set; } = default!;
    }
}
