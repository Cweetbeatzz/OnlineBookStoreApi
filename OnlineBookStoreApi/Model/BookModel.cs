using System.ComponentModel.DataAnnotations;

namespace OnlineBookStoreApi.Model
{
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; } 
        public decimal Price { get; set; } 
        public int AuthorId { get; set; }
        public AuthorModel Author { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }
    }
}
