using Microsoft.EntityFrameworkCore;
using OnlineBookStoreApi.Model;

namespace OnlineBookStoreApi.Database
{
    public class OnlineBookStoreDbcontext : DbContext
    {
        public OnlineBookStoreDbcontext(DbContextOptions<OnlineBookStoreDbcontext> options) : base(options)
        {

        }

        public DbSet<BookModel> Books { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<OrderItemModel> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Authors
            modelBuilder.Entity<AuthorModel>().HasData(
                new AuthorModel { AuthorId = 1, Name = "Ojo Emmanuel" },
                new AuthorModel { AuthorId = 2, Name = "Ojo Segun" },
                new AuthorModel { AuthorId = 3, Name = "Ojo Bukky" },
                new AuthorModel { AuthorId = 4, Name = "Ojo Yemi" }
            );

            // Seed Books
            modelBuilder.Entity<BookModel>().HasData(
                new BookModel { BookId = 1, Title = "Learning EF Core", Price = 40.00m, AuthorId = 1 },
                new BookModel { BookId = 2, Title = "Advanced C#", Price = 50.00m, AuthorId = 2 },
                new BookModel { BookId = 3, Title = "Introduction to Algorithms", Price = 55.00m, AuthorId = 1 },
                new BookModel { BookId = 4, Title = "The Art of Computer Programming", Price = 120.00m, AuthorId = 2 },
                new BookModel { BookId = 5, Title = "Greater Heights", Price = 24.99m, AuthorId = 3 },
                new BookModel { BookId = 6, Title = "Adventures of Tin Tin", Price = 34.99m, AuthorId = 4 },
                new BookModel { BookId = 7, Title = "Effective Java", Price = 45.50m, AuthorId = 1 },
                new BookModel { BookId = 8, Title = "Crime and Punishment", Price = 39.95m, AuthorId = 4 },
                new BookModel { BookId = 9, Title = "Clean Code", Price = 32.00m, AuthorId = 2 },
                new BookModel { BookId = 10, Title = "Being an Engineer", Price = 99.99m, AuthorId = 3 }
            );

            // Seed Orders
            modelBuilder.Entity<OrdersModel>().HasData(
                new OrdersModel { OrderId = 1, OrderDate = DateTime.Now, TotalAmount = 180.00m }
            );

            // Seed OrderItems
            modelBuilder.Entity<OrderItemModel>().HasData(
                new OrderItemModel { OrderItemId = 1, OrderId = 1, BookId = 1, Quantity = 2, Price = 40.00m },
                new OrderItemModel { OrderItemId = 2, OrderId = 1, BookId = 2, Quantity = 2, Price = 50.00m }
            );
        }
    }
}
