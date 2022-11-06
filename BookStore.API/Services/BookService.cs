using BookStore.API.Data;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Services
{
    public class BookService : IBookService
    {

        private readonly BookStoreContext _context;
        public BookService(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<List<BookModel>>GetAllBooks()
        {
            var records = await _context.Books.Select(x => new BookModel()

            {
                BookId = x.BookId,
                Title = x.Title,
                Description = x.Description
            }
            ). ToListAsync();

            return records;

                
         }
    }
}
