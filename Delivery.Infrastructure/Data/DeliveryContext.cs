using Delivery.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Delivery.Infrastructure.Data
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext(DbContextOptions options)
            : base(options) { }

        //public DbSet<Client> Clients { get; set; }
        //public DbSet<Employee> Employees { get; set; }


        public DbSet<Product> Products { get; set; }
        public DbSet<UnitProduct> UnitProducts { get; set; }
        public DbSet<WeightProduct> WeightProducts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<CartUnitItem> CartUnitItems { get; set; }
        public DbSet<CartWeightItem> CartWeightItems { get; set; }
        public DbSet<Cart> Carts { get; set; }

        
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderUnitItem> OrderUnitItems { get; set; }
        public DbSet<OrderWeightItem> OrderWeightItems { get; set; }
        public DbSet<Order> Orders { get; set; }


        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryImage> CategoryImages { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }


        public DbSet<ProductRelatedProduct> ProductRelatedProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            SetTableNamesAsSingle(builder);
            base.OnModelCreating(builder);

            builder.Entity<Product>(ConfigureProduct);

            builder.Entity<ProductRelatedProduct>(ConfigureProductRelatedProduct);
        }

        private static void SetTableNamesAsSingle(ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                builder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            }
        }

        private void ConfigureProduct(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasMany(p => p.ProductRelatedProducts)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigureProductRelatedProduct(EntityTypeBuilder<ProductRelatedProduct> builder)
        {
            builder.HasKey(p => new { p.ProductId, p.RelatedProductId });
        }
    }
}
