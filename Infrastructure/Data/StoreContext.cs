using System;
using System.Linq;
using System.Reflection;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }

        public DbSet<VariantType> VariantTypes { get; set; }
        public DbSet<VariantTypeMember> VariantTypeMembers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<VariantType>(entity =>
            {
                entity.HasIndex(e => e.VariantTypeId);
            });

            modelBuilder.Entity<VariantTypeMember>(entity =>
            {
                entity.HasOne(d => d.VariantType)
                    .WithMany(p => p.VariantTypeMember)
                    .HasForeignKey(d => d.VariantTypeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UnitOfMeasurement)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.UnitOfMeasurementId)
                    .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.ChildCategory)
                    .HasForeignKey(d => d.ParentCategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);


                entity.HasOne(d => d.ProductVariant)
                    .WithMany(p => p.ProductDetail)
                    .HasForeignKey(d => d.ProductVariantId)
                    .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<ProductVariant>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVariant)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);


                entity.HasOne(d => d.FirstVariantTypeMember)
                    .WithMany(p => p.FirstVariantTypeMember)
                    .HasForeignKey(d => d.FirstVariantTypeMemberId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.SecondVariantTypeMember)
                    .WithMany(p => p.SecondVariantTypeMember)
                    .HasForeignKey(d => d.SecondVariantTypeMemberId)
                    .OnDelete(DeleteBehavior.Restrict);

            });

        }
    }
}