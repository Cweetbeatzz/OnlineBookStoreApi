using OnlineBookStoreApi.BookStoreRepository;
using OnlineBookStoreApi.Database;
using OnlineBookStoreApi.Interfaces;

namespace OnlineBookStoreApi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineBookStoreDbcontext onlineBookStoreDbcontext;
        //#########################################################################################

        public UnitOfWork(OnlineBookStoreDbcontext onlineBookStoreDbcontext)
        {
            this.onlineBookStoreDbcontext = onlineBookStoreDbcontext;
        }

        //#########################################################################################


        public IBooksRepository booksRepo => new BooksRepository(onlineBookStoreDbcontext);
        public IOrderRepository ordersRepo => new OrderRepository(onlineBookStoreDbcontext);
        public IAuthorRepository authorRepo => new AuthorRepository(onlineBookStoreDbcontext);

        

        //#########################################################################################

        public async Task<bool> SaveChanges()
        {
            var output = await this.onlineBookStoreDbcontext.SaveChangesAsync() > 0;
            return output;
        }
        //#########################################################################################

    }
}
