using System;
using System.Collections.Generic;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Repositories
{
    public partial class DiamondShopSystemContext : DbContext
    {
        public DiamondShopSystemContext()
        {
        }

        public DiamondShopSystemContext(DbContextOptions<DiamondShopSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; } = null!;
        public virtual DbSet<DiamondGradingReport> DiamondGradingReports { get; set; } = null!;
        public virtual DbSet<Gem> Gems { get; set; } = null!;
        public virtual DbSet<GemPriceList> GemPriceLists { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<MaterialPriceList> MaterialPriceLists { get; set; } = null!;
        public virtual DbSet<Membership> Memberships { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<ProductMaterial> ProductMaterials { get; set; } = null!;
        public virtual DbSet<Warranty> Warranties { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                // optionsBuilder.UseSqlServer("server = (local); database = DiamondShopSystem;uid=sa;pwd=sa;");
                optionsBuilder.UseLazyLoadingProxies();
                var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyDB"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role).HasMaxLength(10);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => e.AccountId, "UQ__Customer__349DA5874099DCFA")
                    .IsUnique()
                    .HasFilter("([AccountID] IS NOT NULL)");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.HasOne(d => d.Account)
                    .WithOne(p => p.Customer)
                    .HasForeignKey<Customer>(d => d.AccountId)
                    .HasConstraintName("FK__Customer__Accoun__3A81B327");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK__Customer__091C2A1B4CF188D0");

                entity.ToTable("CustomerAddress");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerAddress_CustomerID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__CustomerA__Custo__412EB0B6");
            });

            modelBuilder.Entity<DiamondGradingReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK__DiamondG__D5BD48E5B3590D2D");

                entity.ToTable("DiamondGradingReport");

                entity.HasIndex(e => e.GemId, "UQ__DiamondG__F101D5A197EBDB87")
                    .IsUnique()
                    .HasFilter("([GemID] IS NOT NULL)");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.GemId).HasColumnName("GemID");

                entity.Property(e => e.GenerateDate).HasColumnType("date");

                entity.HasOne(d => d.Gem)
                    .WithOne(p => p.DiamondGradingReport)
                    .HasForeignKey<DiamondGradingReport>(d => d.GemId)
                    .HasConstraintName("FK__DiamondGr__GemID__5CD6CB2B");
            });

            modelBuilder.Entity<Gem>(entity =>
            {
                entity.ToTable("Gem");

                entity.Property(e => e.GemId).HasColumnName("GemID");

                entity.Property(e => e.CaratWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Clarity).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Cut).HasMaxLength(50);

                entity.Property(e => e.Fluorescence).HasMaxLength(50);

                entity.Property(e => e.GemName).HasMaxLength(50);

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.Polish).HasMaxLength(50);

                entity.Property(e => e.Shape).HasMaxLength(50);

                entity.Property(e => e.Symmetry).HasMaxLength(50);
            });

            modelBuilder.Entity<GemPriceList>(entity =>
            {
                entity.ToTable("GemPriceList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CaratWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Clarity).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Cut).HasMaxLength(50);

                entity.Property(e => e.EffDate).HasColumnType("date");

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Size).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("Material");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialName).HasMaxLength(50);
            });

            modelBuilder.Entity<MaterialPriceList>(entity =>
            {
                entity.ToTable("MaterialPriceList");

                entity.HasIndex(e => e.MaterialId, "IX_MaterialPriceList_MaterialID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EffDate).HasColumnType("date");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MaterialPriceLists)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK__MaterialP__Mater__4AB81AF0");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Membersh__A4AE64B8AB77A18A");

                entity.ToTable("Membership");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Rank).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.Membership)
                    .HasForeignKey<Membership>(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Membershi__Custo__440B1D61");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.HasIndex(e => e.CustomerId, "IX_Order_CustomerID");

                entity.HasIndex(e => e.SaleStaffId, "IX_Order_SaleStaffID");

                entity.HasIndex(e => e.ShipperId, "IX_Order_ShipperID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderStatus).HasMaxLength(50);

                entity.Property(e => e.PayMethod).HasMaxLength(50);

                entity.Property(e => e.SaleStaffId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SaleStaffID");

                entity.Property(e => e.ShipperId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ShipperID");

                entity.Property(e => e.ShippingDate).HasColumnType("date");

                entity.Property(e => e.ShippingStatus).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Order__CustomerI__5FB337D6");

                entity.HasOne(d => d.SaleStaff)
                    .WithMany(p => p.OrderSaleStaffs)
                    .HasForeignKey(d => d.SaleStaffId)
                    .HasConstraintName("FK__Order__SaleStaff__60A75C0F");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.OrderShippers)
                    .HasForeignKey(d => d.ShipperId)
                    .HasConstraintName("FK__Order__ShipperID__619B8048");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.HasIndex(e => e.OrderId, "IX_OrderDetail_OrderID");

                entity.HasIndex(e => e.ProductId, "IX_OrderDetail_ProductID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.CustomizedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomizedSize).HasMaxLength(50);

                entity.Property(e => e.FinalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__6477ECF3");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__OrderDeta__Produ__656C112C");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.HasIndex(e => e.CustomerId, "IX_Payment_CustomerID");

                entity.HasIndex(e => e.OrderId, "IX_Payment_OrderID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Deposits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PayDetail).HasMaxLength(255);

                entity.Property(e => e.PayMethod).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Payment__Custome__6D0D32F4");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Payment__OrderID__6C190EBB");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.CategoryId, "IX_Product_CategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DifferentCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GemCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaterialCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceRate).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.ProductSize).HasMaxLength(50);

                entity.Property(e => e.ProductionCost).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Product__Categor__4D94879B");

                entity.HasMany(d => d.Gems)
                    .WithMany(p => p.Products)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProductGem",
                        l => l.HasOne<Gem>().WithMany().HasForeignKey("GemId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__ProductGe__GemID__59063A47"),
                        r => r.HasOne<Product>().WithMany().HasForeignKey("ProductId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__ProductGe__Produ__5812160E"),
                        j =>
                        {
                            j.HasKey("ProductId", "GemId").HasName("PK__ProductG__AB1CDBB789957F43");

                            j.ToTable("ProductGem");

                            j.HasIndex(new[] { "GemId" }, "IX_ProductGem_GemID");

                            j.IndexerProperty<int>("ProductId").HasColumnName("ProductID");

                            j.IndexerProperty<int>("GemId").HasColumnName("GemID");
                        });
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__ProductC__19093A2B9D6C05A5");

                entity.ToTable("ProductCategory");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<ProductMaterial>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.MaterialId })
                    .HasName("PK__ProductM__D85CA7DC6CDE5C71");

                entity.ToTable("ProductMaterial");

                entity.HasIndex(e => e.MaterialId, "IX_ProductMaterial_MaterialID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.ProductMaterials)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductMa__Mater__5165187F");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductMaterials)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductMa__Produ__5070F446");
            });

            modelBuilder.Entity<Warranty>(entity =>
            {
                entity.ToTable("Warranty");

                entity.HasIndex(e => e.OrderDetailId, "UQ__Warranty__D3B9D30DBA9C9B64")
                    .IsUnique()
                    .HasFilter("([OrderDetailID] IS NOT NULL)");

                entity.Property(e => e.WarrantyId).HasColumnName("WarrantyID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.OrderDetail)
                    .WithOne(p => p.Warranty)
                    .HasForeignKey<Warranty>(d => d.OrderDetailId)
                    .HasConstraintName("FK__Warranty__OrderD__693CA210");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.HasIndex(e => e.AccountId, "UQ__Staff__349DA5870B6A8E6C")
                    .IsUnique()
                    .HasFilter("([AccountID] IS NOT NULL)");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StaffID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithOne(p => p.staff)
                    .HasForeignKey<staff>(d => d.AccountId)
                    .HasConstraintName("FK__Staff__AccountID__3E52440B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
