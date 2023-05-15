using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SmallShopIT.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Software" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Printers" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Personal Computers" });

            //seed products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Komputer",
                Price = 2999.99M,
                ShortDesc = "Komputer krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 3,
                Image = "/Images/desktop_pc.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Laptop",
                Price = 999.99M,
                ShortDesc = "Laptop krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 3,
                Image = "/Images/laptop.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Drukarka",
                Price = 400.00M,
                ShortDesc = "Drukarka krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 2,
                Image = "/Images/printer.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Software",
                Price = 900.00M,
                ShortDesc = "Software krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 1,
                Image = "/Images/software.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Software2",
                Price = 9000.00M,
                ShortDesc = "Software2 krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 1,
                Image = "/Images/software2.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Super komputer",
                Price = 12000.00M,
                ShortDesc = "Super komputer krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 3,
                Image = "/Images/super_pc.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Super Laptop",
                Price = 7000.00M,
                ShortDesc = "Super Laptop krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 3,
                Image = "/Images/super_laptop.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Super Drukarka",
                Price = 5000.00M,
                ShortDesc = "Super Drukarka krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 2,
                Image = "/Images/super_printer.jpg",
                InStock = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Software3",
                Price = 900.00M,
                ShortDesc = "Software3 krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 1,
                Image = "/Images/software3.jpg",
                InStock = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Komputer2",
                Price = 1500.00M,
                ShortDesc = "Komputer2 krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 1,
                Image = "/Images/desktop_pc2.jpg",
                InStock = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Drukarka2",
                Price = 244.00M,
                ShortDesc = "Drukarka2 krótki opis.",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                CategoryId = 2,
                Image = "/Images/printer2.jpg",
                InStock = true
            });

        }
    }
}
