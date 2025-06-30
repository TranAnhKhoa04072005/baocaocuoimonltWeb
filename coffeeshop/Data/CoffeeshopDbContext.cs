using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using coffeeshop.Models;
using Microsoft.EntityFrameworkCore;


namespace coffeeshop.Data
{
    public class CoffeeshopDbContext : IdentityDbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Đề thpt môn Toán",
                Price = 25,
                Detail = "Name product",
                ImageUrl =
            "https://vnexpress.net/de-tieng-anh-thi-tot-nghiep-thpt-2025-tat-ca-48-ma-de-4906278.html#lg=gallery_1&slide=0"
            },
            new Product
            {
                Id = 2,
                Name = "Đề thpt môn Văn",
                Price = 20,
                Detail = "Vietnamese product",
                ImageUrl =
            "https://vnexpress.net/de-tieng-anh-thi-tot-nghiep-thpt-2025-tat-ca-48-ma-de-4906278.html#lg=gallery_1&slide=0"
            },
            new Product
            {
                Id = 3,
                Name = "Đề thpt Môn Anh",
                Price = 15,
                Detail = "UK product",
                ImageUrl =
            "https://vnexpress.net/de-tieng-anh-thi-tot-nghiep-thpt-2025-tat-ca-48-ma-de-4906278.html#lg=gallery_1&slide=0"
            },
            new Product
            {
                Id = 4,
                Name = "Đề thi đánh giá năng lực",
                Price = 15,
                Detail = "India product",
                ImageUrl =
            "https://vnexpress.net/de-tieng-anh-thi-tot-nghiep-thpt-2025-tat-ca-48-ma-de-4906278.html#lg=gallery_1&slide=0"
            },
            new Product
            {
                Id = 5,
                Name = "Đề đánh giá vào 10",
                Price = 25,
                Detail = "Russian product",
                ImageUrl =
            "https://vnexpress.net/de-tieng-anh-thi-tot-nghiep-thpt-2025-tat-ca-48-ma-de-4906278.html#lg=gallery_1&slide=0"
            },
            new Product
            {
                Id = 6,
                Name = "Đề thpt 2025",
                Price = 35,
                Detail = "France product",
                ImageUrl =
            "https://vnexpress.net/de-tieng-anh-thi-tot-nghiep-thpt-2025-tat-ca-48-ma-de-4906278.html#lg=gallery_1&slide=0"
            }
            );
        }

    }
}
