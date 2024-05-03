using Microsoft.EntityFrameworkCore;
using OnlineBookStoreApi.Database;
using OnlineBookStoreApi.Interfaces;
using OnlineBookStoreApi.Model;

namespace OnlineBookStoreApi.BookStoreRepository
{
    public class BooksRepository : IBooksRepository
    {
        private readonly OnlineBookStoreDbcontext db;
        public BooksRepository(OnlineBookStoreDbcontext db)
        {
            this.db = db;
        }

        //############################################################

        public async Task<bool> DeleteBooks(List<int> allIds)
        {
            var booksToDelete = await this.db.Books.Where(b => allIds.Contains(b.BookId)).ToListAsync();

            if (booksToDelete.Count == 0)
            {
                return false; 
            }

            this.db.Books.RemoveRange(booksToDelete);
            await this.db.SaveChangesAsync(); 

            return true; 
        }

        //############################################################

    }
}
