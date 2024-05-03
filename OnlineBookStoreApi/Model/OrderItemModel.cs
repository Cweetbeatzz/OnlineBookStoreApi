using System.ComponentModel.DataAnnotations;

namespace OnlineBookStoreApi.Model
{
    public class OrderItemModel
    {
        [Key]
        public int OrderItemId { get; set; }
        public int BookId { get; set; }
        public BookModel Book { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public OrdersModel Order { get; set; }
    }
}
