using BookService.Data;
using BookService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly DataContext _context;
        public BookController(DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Gets all books from user's library
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<BookModel>>> GetBooks()
        {
            return Ok(await _context.BookModels.ToListAsync());
        }
        /// <summary>
        /// gets a specific book from user's library
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<BookModel>> GetBookById(int id)
        {
            var book = await _context.BookModels.FindAsync(id);
            if (book == null)
                return BadRequest("Book not found.");
            return Ok(book);
        }
        /// <summary>
        /// deletes a specific book from user's library
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<BookModel>>> DeleteBookById(int id)
        {
            var dbbook = await _context.BookModels.FindAsync(id);
            if (dbbook == null)
                return BadRequest("Book not found.");
            _context.BookModels.Remove(dbbook);
            await _context.SaveChangesAsync();
            return Ok(await _context.BookModels.ToListAsync());
        }
    }
}
