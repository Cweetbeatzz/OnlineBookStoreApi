using System.ComponentModel.DataAnnotations;

namespace OnlineBookStoreApi.Model
{
    public class AuthorModel
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public List<BookModel> Books { get; set; }
    }
}
