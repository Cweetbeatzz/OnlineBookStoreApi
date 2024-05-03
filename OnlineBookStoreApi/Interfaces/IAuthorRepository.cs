using OnlineBookStoreApi.Dtos;

namespace OnlineBookStoreApi.Interfaces
{
    public interface IAuthorRepository
    {
        Task<List<AuthorSalesDto>> GetTopSellingAuthors(int count);
    }
}