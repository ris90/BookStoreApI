using BookStore.API.Models;

namespace BookStore.API.Services
{
    public interface IBookService
    {
        Task<List<BookModel>> GetAllBooks();
    }
}
