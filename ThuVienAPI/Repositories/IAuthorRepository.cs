using ThuVienAPI.Models.Domain;
using ThuVienAPI.Models.DTO;

namespace ThuVienAPI.Repositories
{
    public interface IAuthorRepository
    {

        List<AuthorDTO> GellAllAuthors();
        AuthorNoIdDTO GetAuthorById(int id);
        AddAuthorRequestDTO AddAuthor(AddAuthorRequestDTO addAuthorRequestDTO);
        AuthorNoIdDTO UpdateAuthorById(int id, AuthorNoIdDTO authorNoIdDTO);
        Authors? DeleteAuthorById(int id);
    }
}
