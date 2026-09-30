using ThuVienAPI.Models.Domain;
using ThuVienAPI.Models.DTO;

namespace ThuVienAPI.Repositories
{
    public interface IBookRepository
    {
        List<BookWithAuthorAndPublisherDTO> GetAllBooks(string? filterOn = null, string? filterQuery = null, string? sortBy = null,
        bool isAscending = true, int pageNumber = 1, int pageSize = 1000);
        BookWithAuthorAndPublisherDTO GetBookById(int id);
        addBookRequestDTO AddBook(addBookRequestDTO addBookRequestDTO);
        addBookRequestDTO? UpdateBookById(int id, addBookRequestDTO bookDTO);
        Books? DeleteBookById(int id);
    }
}
