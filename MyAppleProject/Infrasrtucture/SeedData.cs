using Microsoft.EntityFrameworkCore;
using MyAppleProject.Infrasrtucture;
using MyAppleProject.Models;

namespace MyAppleProject.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category Iphone = new Category { Name = "Iphone", Slug = "iphone" };
                Category Macbook = new Category { Name = "Macbook", Slug = "macbook" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "AppleiPhone14red128",
                            Slug = "iphone14red128",
                            Description = "Apple iPhone 14 eSIM 128 ГБ, Product (RED)",
                            Price = 75990,
                            Category = Iphone,
                            Image = "iphone14red128.jpg"
                        },
                        new Product
                        {
                            Name = "AppleiPhone14Plus128",
                            Slug = "iphone14plus128",
                            Description = "Apple iPhone 14 Plus dual-SIM 128 ГБ, голубой",
                            Price = 89990,
                            Category = Iphone,
                            Image = "iphone14plus128.png"
                        },
                        new Product
                        {
                            Name = "AppleiPhone14Pro1Tb",
                            Slug = "iphone14pro1Tb",
                            Description = "Apple iPhone 14 Pro eSIM 1 ТБ, серый космос",
                            Price = 169990,
                            Category = Iphone,
                            Image = "iphone14pro1Tb.png"
                        },
                        new Product
                        {
                            Name = "AppleiPhone14ProMax128",
                            Slug = "iphone14promax128",
                            Description = "Apple iPhone 14 Pro Max eSIM 128 ГБ, темно-фиолетовый",
                            Price = 129990,
                            Category = Iphone,
                            Image = "iphone14promax128.png"
                        },
                        new Product
                        {
                            Name = "AppleMacbookAir13d256M2",
                            Slug = "applemacbookair13d256m2",
                            Description = "Apple macbook Air 13'' 256 ГБ, с чипом Apple M2, серый космос",
                            Price = 119990,
                            Category = Macbook,
                            Image = "macbook13-256.png"
                        },
                        new Product
                        {
                            Name = "AppleMacbookAir13d256M1",
                            Slug = "applemacbookair13d256m1",
                            Description = "Apple macbook Air 13'' 256 ГБ, с чипом Apple M1, серый космос",
                            Price = 85990,
                            Category = Macbook,
                            Image = "macbook13-256M1.png"
                        },
                        new Product
                        {
                            Name = "AppleMacbookAir16d512M2",
                            Slug = "applemacbookair16d512m2",
                            Description = "Apple macbook Air 16'' 512 ГБ, с чипом Apple M2, серебристый",
                            Price = 209990,
                            Category = Macbook,
                            Image = "macbook16-512M2.png"
                        },
                         new Product
                        {
                            Name = "AppleMacbookAir16d1TbM2",
                            Slug = "applemacbookair16d1tbm2",
                            Description = "Apple macbook Air 16'' 1 TБ, с чипом Apple M2, серебристый",
                            Price = 249990,
                            Category = Macbook,
                            Image = "macbook16-1TbM2.png"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}