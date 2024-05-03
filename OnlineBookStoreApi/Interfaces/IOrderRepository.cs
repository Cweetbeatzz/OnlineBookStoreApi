namespace OnlineBookStoreApi.Interfaces
{
    public interface IOrderRepository
    {
        Task<decimal> GetRevenue(DateTime startDate, DateTime endDate);
    }
}