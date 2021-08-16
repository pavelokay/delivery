using Delivery.Core.Entities;
using Delivery.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Data
{
    public class DeliveryContextSeed
    {
        public static async Task SeedAsync(DeliveryContext dbContext, ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;

            try
            {

            }
            catch (Exception ex)
            {
                if (retryForAvailability < 3)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<DeliveryContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(dbContext, loggerFactory, retryForAvailability);
                }
                throw;
            }
        }

        private static async Task SeedManufacturersAsync(DeliveryContext context)
        {
            if (context.Manufacturers.Any())
            {
                return;
            }
            #region AddManufacturers
            context.Manufacturers.AddRange(
                new Manufacturer
                {
                    Name = "Владивосток рыбзавод",
                    Description = "Владивосток рыбзавод ул.Ленина 2"
                },
                new Manufacturer
                {
                    Name = "Хабаровск рыбзавод",
                    Description = "Хабаровск рыбзавод ул.Ленина 4"
                },
                new Manufacturer
                {
                    Name = "Находка рыбзавод",
                    Description = "Находка рыбзавод ул.Ленина 5"
                },
                new Manufacturer
                {
                    Name = "Уссурийск рыбзавод",
                    Description = "Уссурийск рыбзавод ул.Ленина 6"
                });
            await context.SaveChangesAsync();
            #endregion
        }

        private static async Task SeedCategoriesAsync(DeliveryContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }
            #region AddCategories
            context.Categories.AddRange(
                new Category
                {
                    Name = "Кальмары",
                    Description = "Категория с кальмарами"
                },
                new Category
                {
                    Name = "Мидии",
                    Description = "Категория с кальмарами"
                },
                new Category
                {
                    Name = "Рыба",
                    Description = "Категория с кальмарами"
                },
                new Category
                {
                    Name = "Крабы",
                    Description = "Категория с кальмарами"
                },
                new Category
                {
                    Name = "Раки",
                    Description = "Категория с кальмарами"
                },
                new Category
                {
                    Name = "Креветки",
                    Description = "Категория с кальмарами"
                },
                new Category
                {
                    Name = "Гребешки",
                    Description = "Категория с кальмарами"
                },
                new Category
                {
                    Name = "Моллюски",
                    Description = "Категория с кальмарами"
                },
                new Category
                {
                    Name = "Икра",
                    Description = "Категория с кальмарами"
                },
                new Category
                {
                    Name = "Консервы",
                    Description = "Категория с кальмарами"
                });
            await context.SaveChangesAsync();
            #endregion
            #region AddCategoryImages
            context.CategoryImages.AddRange(
                new CategoryImage
                {
                    ImageFile = "Fish.jpg",
                    AltName = "Рыба",
                    CategoryId = 1
                });
            await context.SaveChangesAsync();
            #endregion
        }

        private static async Task SeedReviewsAsync(DeliveryContext context)
        {
            if (context.Reviews.Any())
            {
                return;
            }
            #region AddReviews

            #endregion

            await context.SaveChangesAsync();
        }

        private static async Task SeedProductsAsync(DeliveryContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            #region AddProducts
            context.AddRange(
                new UnitProduct
                {
                    Name = "Дальневосточная креветка",
                    CategoryId = context.Categories.FirstOrDefault(p => p.Name == "Креветки").Id,
                    Description = "Дальневосточная креветка блочная замороженная",
                    Weight = 5.0,
                    ManufacturerId = context.Manufacturers.FirstOrDefault(m => m.Name == "Владивосток рыбзавод").Id,
                    QuantityInPackage = 50,
                    Slug = "dfds123",
                    UnitsInStock = 150,
                    UnitOfMeasurement = UnitOfMeasurement.Unity,
                    UnitPrice = 5000M,
                    Status = ProductStatus.inStore,
                },
                new UnitProduct
                {
                    Name = "Северная мидия",
                    CategoryId = context.Categories.FirstOrDefault(p => p.Name == "Мидии").Id,
                    Description = "Северная мидия блочная замороженная",
                    Weight = 3.0,
                    ManufacturerId = context.Manufacturers.FirstOrDefault(m => m.Name == "Находка рыбзавод").Id,
                    QuantityInPackage = 40,
                    Slug = "dfds343",
                    UnitsInStock = 120,
                    UnitOfMeasurement = UnitOfMeasurement.Unity,
                    UnitPrice = 4500M,
                    Status = ProductStatus.inStore,
                },
                new WeightProduct
                {
                    Name = "Красная икра кета",
                    CategoryId = context.Categories.FirstOrDefault(p => p.Name == "Икра").Id,
                    Description = "Красная икра кета",
                    ManufacturerId = context.Manufacturers.FirstOrDefault(m => m.Name == "Владивосток рыбзавод").Id,
                    Slug = "dfds543",
                    KiloInStock = 150,
                    PricePerKilo = 6000M,
                    Status = ProductStatus.inStore,
                },
                new UnitProduct
                {
                    Name = "Дальневосточный краб",
                    CategoryId = context.Categories.FirstOrDefault(p => p.Name == "Крабы").Id,
                    Description = "Дальневосточный краб блочный замороженный",
                    Weight = 10.0,
                    ManufacturerId = context.Manufacturers.FirstOrDefault(m => m.Name == "Находка рыбзавод").Id,
                    QuantityInPackage = 10,
                    Slug = "dsds143",
                    UnitsInStock = 100,
                    UnitOfMeasurement = UnitOfMeasurement.Unity,
                    UnitPrice = 3000M,
                    Status = ProductStatus.inStore,
                },
                new UnitProduct
                {
                    Name = "Краб стрегун",
                    CategoryId = context.Categories.FirstOrDefault(p => p.Name == "Крабы").Id,
                    Description = "Краб стрегун блочный замороженный",
                    Weight = 12.0,
                    ManufacturerId = context.Manufacturers.FirstOrDefault(m => m.Name == "Хабаровск рыбзавод").Id,
                    QuantityInPackage = 15,
                    Slug = "dfsd523",
                    UnitsInStock = 800,
                    UnitOfMeasurement = UnitOfMeasurement.Unity,
                    UnitPrice = 2500M,
                    Status = ProductStatus.inStore,
                },
                new UnitProduct
                {
                    Name = "Королевская креветка",
                    CategoryId = context.Categories.FirstOrDefault(p => p.Name == "Креветки").Id,
                    Description = "Королевская креветка креветка блочная замороженная",
                    Weight = 4.0,
                    ManufacturerId = context.Manufacturers.FirstOrDefault(m => m.Name == "Владивосток рыбзавод").Id,
                    QuantityInPackage = 30,
                    Slug = "dsdv453",
                    UnitsInStock = 250,
                    UnitOfMeasurement = UnitOfMeasurement.Unity,
                    UnitPrice = 3500M,
                    Status = ProductStatus.inStore,
                });
            #endregion

            #region AddProductImages
            context.ProductImages.AddRange(
                new ProductImage
                {
                    ImageFile = "Crab.jpg",
                    AltName = "Crab",
                    ProductId = 1
                });
            #endregion

            await context.SaveChangesAsync();
        }
    }
}
