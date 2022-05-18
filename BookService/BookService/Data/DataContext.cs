using BookService.Models;
using Microsoft.EntityFrameworkCore;

namespace BookService.Data
{
    public class DataContext : DbContext
    {
        public DbSet<BookModel> BookModels { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
