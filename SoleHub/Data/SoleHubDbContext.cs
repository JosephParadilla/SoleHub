using Microsoft.EntityFrameworkCore;
using SoleHub.Models;

namespace SoleHub.Data
{
    public class SoleHubDbContext : DbContext
    {
        public SoleHubDbContext(DbContextOptions<SoleHubDbContext> options)
            : base(options)
        {
        }

        public DbSet<WishlistItem> WishlistItems { get; set; }
        public DbSet<Product> Products => Set<Product>();

        public DbSet<UserProfile> UserProfiles => Set<UserProfile>();

        public DbSet<UserAccount> UserAccounts => Set<UserAccount>();

        public DbSet<CartItem> CartItems => Set<CartItem>();

        public DbSet<Order> Orders => Set<Order>();

        public DbSet<OrderItem> OrderItems => Set<OrderItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(product => product.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(orderItem => orderItem.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(order => order.ShippingFee)
                .HasPrecision(18, 2);

            modelBuilder.Entity<CartItem>()
                .HasOne(cartItem => cartItem.Product)
                .WithMany()
                .HasForeignKey(cartItem => cartItem.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CartItem>()
                .HasOne(cartItem => cartItem.UserProfile)
                .WithMany()
                .HasForeignKey(cartItem => cartItem.UserProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(order => order.UserProfile)
                .WithMany()
                .HasForeignKey(order => order.UserProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(orderItem => orderItem.Order)
                .WithMany(order => order.Items)
                .HasForeignKey(orderItem => orderItem.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserAccount>().HasData(
                new UserAccount
                {
                    Id = 1,
                    FullName = "SoleHub Admin",
                    Username = "admin",
                    Password = "admin123",
                    Role = "Admin"
                },
                new UserAccount
                {
                    Id = 2,
                    FullName = "Juan Dela Cruz",
                    Username = "customer",
                    Password = "customer123",
                    Role = "Customer"
                }
            );

            modelBuilder.Entity<UserProfile>().HasData(
                new UserProfile
                {
                    Id = 1,
                    FullName = "SoleHub Admin",
                    Email = "admin@solehub.com",
                    Address = "Cebu City, Philippines",
                    ProfilePictureUrl = ""
                },
                new UserProfile
                {
                    Id = 2,
                    FullName = "Juan Dela Cruz",
                    Email = "customer@solehub.com",
                    Address = "Cebu City, Philippines",
                    ProfilePictureUrl = ""
                }
            );

            

            var extraImageFiles = new[]
            {
                "nike16.png", "nike17.png", "nike18.png", "nike20.png", "nike21.png", "nikke19.png",

                "ad1.png", "ad2.png", "ad3.png", "ad4.png", "ad6.png", "ad7.png", "ad8.png", "ad9.png", "ad10.png",
                "ad11.png", "ad12.png", "ad14.png", "ad15.png", "ad16.png", "ad17.png", "ad18.png", "ad19.png", "ad20.png",
                "ad22.png", "ad23.png", "ad24.png", "ad25.png", "ad26.png", "ad27.png", "ad28.png", "ad29.png", "ad30.png",
                "ad31.png", "ad32.png", "ad33.png", "ad34.png", "ad35.png", "ad36.png",

                "nike2.png", "nike3.png", "nike4.png", "nike5.png", "nike6.png", "nike7.png", "nike8.png",
                "nike9.png", "nike10.png", "nike11.png", "nike12.png", "nike13.png", "nike14.png", "nike15.png",

                "nb1.png", "nb2.png", "nb3.png", "nb4.png", "nb5.png", "nb6.png", "nb7.png", "nb202rbl.png",

                "hoka1.png", "hoka2.png", "hoka5.png",

                "vans1.png", "vans2.png", "vans3.png",

                "c2.png", "c3.png", "c4.png", "c5.png", "c6.png", "c7.png", "c8.png", "c9.png", "c10.png",
                "c11.png", "c12.png", "c13.png", "c14.png", "c15.png", "c16.png", "c17.png", "c18.png", "c19.png", "c20.png",
                "c21.png", "c23.png", "c24.png", "c25.png", "c26.png", "c27.png", "c28.png", "c29.png", "c30.png",

                "p1.png", "p2.png", "p3.png", "p4.png", "p5.png", "p6.png", "p7.png", "p8.png", "p9.png", "p10.png",
                "p11.png", "p12.png", "p13.png", "p14.png", "p15.png", "p16.png", "p17.png", "p18.png", "p19.png", "p20.png",
                "p21.png", "p22.png", "p23.png", "p24.png", "p25.png",

                "r1.png", "r2.png", "r4.png", "r5.png", "r6.png", "r7.png", "r8.png", "r9.png", "r10.png",
                "r11.png", "r12.png", "r13.png", "r14.png", "r15.png", "r16.png", "r17.png",

                "s1.png", "s2.png", "s3.png", "s4.png", "s5.png", "s6.png", "s7.png", "s8.png", "s9.png"
            };

            var extraProducts = new Product[extraImageFiles.Length];

            for (int i = 0; i < extraImageFiles.Length; i++)
            {
                var fileName = extraImageFiles[i];
                var productId = i + 13;

                string brand;
                string category;

                if (fileName.StartsWith("ad"))
                {
                    brand = "Adidas";
                    category = "Lifestyle";
                }
                else if (fileName.StartsWith("nike") || fileName.StartsWith("nikke"))
                {
                    brand = "Nike";
                    category = "Running";
                }
                else if (fileName.StartsWith("nb"))
                {
                    brand = "New Balance";
                    category = "Running";
                }
                else if (fileName.StartsWith("hoka"))
                {
                    brand = "Hoka";
                    category = "Running";
                }
                else if (fileName.StartsWith("vans"))
                {
                    brand = "Vans";
                    category = "Skate";
                }
                else if (fileName.StartsWith("yeezy"))
                {
                    brand = "Adidas";
                    category = "Slides";
                }
                else if (fileName.StartsWith("r"))
                {
                    brand = "Reebok";
                    category = "Running";
                }
                else if (fileName.StartsWith("s"))
                {
                    brand = "Skechers";
                    category = "Lifestyle";
                }
                else if (fileName.StartsWith("p"))
                {
                    brand = "Puma";
                    category = "Lifestyle";
                }
                else
                {
                    brand = "SoleHub";
                    category = "Lifestyle";
                }

                extraProducts[i] = new Product
                {
                    Id = productId,
                    Name = $"{brand} Shoe {productId}",
                    Brand = brand,
                    Category = category,
                    Price = 4995.00m + ((i % 10) * 500),
                    ImageUrl = $"/images/{fileName}"
                };
            }

            modelBuilder.Entity<Product>().HasData(extraProducts);
        }
    }
}