using BookStore.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookservice;
        public BooksController(IBookService bookservice)
        {
            _bookservice = bookservice;
        }

        [HttpGet("")]

        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookservice.GetAllBooks();
            return Ok(books);
        }

    }
}
