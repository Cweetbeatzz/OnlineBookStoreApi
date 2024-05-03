using OnlineBookStoreApi.Model;

namespace OnlineBookStoreApi.Interfaces
{
    public interface IBooksRepository
    {
        Task<bool> DeleteBooks(List<int> allIds);
    }
}