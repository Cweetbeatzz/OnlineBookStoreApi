namespace OnlineBookStoreApi.Dtos
{
    public class AuthorSalesDto
    {
        public required string AuthorName { get; set; }
        public decimal TotalSales { get; set; } = 0;
    }
}
