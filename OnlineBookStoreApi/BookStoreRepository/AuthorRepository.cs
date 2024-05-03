using Microsoft.EntityFrameworkCore;
using OnlineBookStoreApi.Database;
using OnlineBookStoreApi.Dtos;
using OnlineBookStoreApi.Interfaces;

namespace OnlineBookStoreApi.BookStoreRepository
{
    public class AuthorRepository : IAuthorRepository

    //#########################################################################################

    {
        private readonly OnlineBookStoreDbcontext db;
        //#########################################################################################

        public AuthorRepository(OnlineBookStoreDbcontext db)
        {
            this.db = db;
        }
        //#########################################################################################

        public async Task<List<AuthorSalesDto>> GetTopSellingAuthors(int count)
        {

            var bookSales = await this.db.Books
            .Select(b => new
            {
                AuthorName = b.Author.Name,
                BookSales = b.OrderItems.Sum(oi => oi.Quantity * oi.Price) 
            })
            .ToListAsync();

            
            var authorSales = bookSales
                .GroupBy(b => b.AuthorName)
                .Select(group => new AuthorSalesDto
                {
                    AuthorName = group.Key,
                    TotalSales = group.Sum(b => b.BookSales) 
                })
                .OrderByDescending(a => a.TotalSales)
                .Take(count)
                .ToList();

            return authorSales;
        }
        //#########################################################################################

    }
}
