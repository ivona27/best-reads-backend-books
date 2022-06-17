using Google.Apis.Books.v1;
using Google.Apis.Services;
using Microsoft.AspNetCore.Mvc;
using UserService.Models;

namespace UserService.Controllers
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
        /// search for a book in Google Books API by theit id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/volumes/volumeId")]
        public async Task<IActionResult> GetBookById(string id)
        {
            var service = new BooksService(new BaseClientService.Initializer
            {
                ApiKey = "AIzaSyCelBA6XG6hpQ9hZc3_imP02BCzxLMjDms",
            });
            var result = service.Volumes.Get(id).Execute();
            return Ok(result);
        }
        /// <summary>
        /// search for a book in Google Books API by a search word
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        [HttpGet("/volumes")]
        public async Task<IActionResult> SearchBooks(string q)
        {
            var service = new BooksService(new BaseClientService.Initializer
            {
                ApiKey = "AIzaSyCelBA6XG6hpQ9hZc3_imP02BCzxLMjDms",
            });
            var result = service.Volumes.List(q).Execute().Items.Take(5);
            return Ok(result);
        }
    }
}
