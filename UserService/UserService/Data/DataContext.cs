using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace UserService.Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// save instances of the user model
        /// </summary>
        public DbSet<UserModel> UserModels { get; set; }
        /// <summary>
        /// save instances of the book model
        /// </summary>
        public DbSet<BookModel> BookModels { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
