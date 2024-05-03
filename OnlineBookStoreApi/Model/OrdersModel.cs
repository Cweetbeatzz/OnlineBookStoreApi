using System.ComponentModel.DataAnnotations;

namespace OnlineBookStoreApi.Model
{
    public class OrdersModel
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
