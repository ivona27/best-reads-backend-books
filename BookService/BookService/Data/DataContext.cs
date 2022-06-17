using BookService.Models;
using Microsoft.EntityFrameworkCore;

namespace BookService.Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// saves instances of the book model
        /// </summary>
        public DbSet<BookModel> BookModels { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
