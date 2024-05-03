using OnlineBookStoreApi.Interfaces;

namespace OnlineBookStoreApi.UnitOfWork
{
    public interface IUnitOfWork
    {
        IBooksRepository booksRepo { get; }
        IAuthorRepository authorRepo { get; }
        IOrderRepository ordersRepo { get; }

        Task<bool> SaveChanges();
    }
}