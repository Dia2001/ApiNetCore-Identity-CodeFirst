using ApiNetCore_Identity_CodeFirst.Models;

namespace ApiNetCore_Identity_CodeFirst.Repositories
{
    public interface IBookRepository
    {
        public Task<List<BookModel>> GetAllBooksAsync();
        public Task<BookModel> GetBookAsync(int id);
        public Task<int> AddBookAsync(BookModel model);
        public Task UpdateBookAsync(int id, BookModel model);
        public Task DeleteBookAsync(int id);
    }
}
