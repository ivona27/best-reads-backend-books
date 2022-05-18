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

        [HttpGet]
        public async Task<ActionResult<List<BookModel>>> GetBooks()
        {
            return Ok(await _context.BookModels.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookModel>> GetBookById(int id)
        {
            var book = await _context.BookModels.FindAsync(id);
            if (book == null)
                return BadRequest("Book not found.");
            return Ok(book);
        }

        //GetBooksByUserId

        //GetBookByISBN

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
