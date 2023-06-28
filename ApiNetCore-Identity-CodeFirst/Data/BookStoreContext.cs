using Microsoft.EntityFrameworkCore;

namespace ApiNetCore_Identity_CodeFirst.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> opt) : base(opt)
        {

        }

        #region DbSet
        public DbSet<Book>? Books { get; set; }
        #endregion
    }
}
