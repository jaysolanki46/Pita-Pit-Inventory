using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pita_Pit_Inventory.Models
{
    public partial class PitaPitDbContext : DbContext
    {
        public PitaPitDbContext()
        {
        }

        public PitaPitDbContext(DbContextOptions<PitaPitDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductSupplier> ProductSupplier { get; set; }
        public virtual DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Pita_Pit_Inventory_App;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Groups>(entity =>
            {
                entity.Property(e => e.GroupName).IsUnicode(false);
            });

            modelBuilder.Entity<Ingredients>(entity =>
            {
                entity.Property(e => e.IngredientItemCode).IsUnicode(false);

                entity.Property(e => e.IngredientItemName).IsUnicode(false);

                entity.Property(e => e.IngredientItemSize).IsUnicode(false);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.Property(e => e.LocationName).IsUnicode(false);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.ProductDescription).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.Property(e => e.ProductPackSize).IsUnicode(false);

                entity.Property(e => e.ProductSku).IsUnicode(false);

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductGroupId)
                    .HasConstraintName("FK_Group");

                entity.HasOne(d => d.ProductLocation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductLocationId)
                    .HasConstraintName("FK_Location");
            });

            modelBuilder.Entity<ProductSupplier>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSupplier)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Product");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ProductSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Supplier");
            });

            modelBuilder.Entity<RecipeIngredients>(entity =>
            {
                entity.HasOne(d => d.IngredientItem)
                    .WithMany(p => p.RecipeIngredients)
                    .HasForeignKey(d => d.IngredientItemId)
                    .HasConstraintName("FK_Ingredient");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeIngredients)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK_Recipe");
            });

            modelBuilder.Entity<Recipes>(entity =>
            {
                entity.Property(e => e.RecipeName).IsUnicode(false);

                entity.Property(e => e.RecipePrice).IsUnicode(false);
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.Property(e => e.SupplierAddress).IsUnicode(false);

                entity.Property(e => e.SupplierEmail).IsUnicode(false);

                entity.Property(e => e.SupplierName).IsUnicode(false);

                entity.Property(e => e.SupplierNote).IsUnicode(false);

                entity.Property(e => e.SupplierSku).IsUnicode(false);
            });
        }
    }
}
