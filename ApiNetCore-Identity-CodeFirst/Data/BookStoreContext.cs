using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCore_Identity_CodeFirst.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> option) : base(option)
        {

        }

        #region DbSet
        public DbSet<Book>? Books { get; set; }
        #endregion
    }
}
