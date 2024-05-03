using Microsoft.EntityFrameworkCore;
using OnlineBookStoreApi.Database;
using OnlineBookStoreApi.Interfaces;

namespace OnlineBookStoreApi.BookStoreRepository
{
    public class OrderRepository : IOrderRepository
    {
        //############################################################

        private readonly OnlineBookStoreDbcontext db;

        //############################################################

        public OrderRepository(OnlineBookStoreDbcontext db)
        {
            this.db = db;
        }
        //############################################################


        public async Task<decimal> GetRevenue(DateTime startDate, DateTime endDate)
        {
            return await this.db.Orders
                                 .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                                 .SumAsync(o => o.TotalAmount);
        }
        //############################################################

    }
}
