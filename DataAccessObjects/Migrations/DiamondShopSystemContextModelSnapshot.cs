﻿// <auto-generated />
using System;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessObjects.Migrations
{
    [DbContext(typeof(DiamondShopSystemContext))]
    partial class DiamondShopSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessObjects.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AccountID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("AccountId");

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("AccountID");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Point")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex(new[] { "AccountId" }, "UQ__Customer__349DA5874099DCFA")
                        .IsUnique()
                        .HasFilter("([AccountID] IS NOT NULL)");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.CustomerAddress", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AddressID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.HasKey("AddressId")
                        .HasName("PK__Customer__091C2A1B4CF188D0");

                    b.HasIndex(new[] { "CustomerId" }, "IX_CustomerAddress_CustomerID");

                    b.ToTable("CustomerAddress", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.DiamondGradingReport", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReportID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportId"), 1L, 1);

                    b.Property<int?>("GemId")
                        .HasColumnType("int")
                        .HasColumnName("GemID");

                    b.Property<DateTime?>("GenerateDate")
                        .HasColumnType("date");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ReportId")
                        .HasName("PK__DiamondG__D5BD48E5B3590D2D");

                    b.HasIndex(new[] { "GemId" }, "UQ__DiamondG__F101D5A197EBDB87")
                        .IsUnique()
                        .HasFilter("([GemID] IS NOT NULL)");

                    b.ToTable("DiamondGradingReport", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.Gem", b =>
                {
                    b.Property<int>("GemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GemID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GemId"), 1L, 1);

                    b.Property<decimal?>("CaratWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Clarity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Color")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cut")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Fluorescence")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GemName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Origin")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Polish")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Shape")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Symmetry")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GemId");

                    b.ToTable("Gem", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.GemPriceList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("CaratWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Clarity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Color")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cut")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("EffDate")
                        .HasColumnType("date");

                    b.Property<string>("Origin")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Size")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("GemPriceList", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaterialID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"), 1L, 1);

                    b.Property<string>("MaterialName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaterialId");

                    b.ToTable("Material", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.MaterialPriceList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("EffDate")
                        .HasColumnType("date");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int")
                        .HasColumnName("MaterialID");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "MaterialId" }, "IX_MaterialPriceList_MaterialID");

                    b.ToTable("MaterialPriceList", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.Membership", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<decimal?>("DiscountRate")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("Rank")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerId")
                        .HasName("PK__Membersh__A4AE64B8AB77A18A");

                    b.ToTable("Membership", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("date");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PayMethod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SaleStaffId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SaleStaffID");

                    b.Property<string>("ShipperId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("ShipperID");

                    b.Property<DateTime?>("ShippingDate")
                        .HasColumnType("date");

                    b.Property<string>("ShippingStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("OrderId");

                    b.HasIndex(new[] { "CustomerId" }, "IX_Order_CustomerID");

                    b.HasIndex(new[] { "SaleStaffId" }, "IX_Order_SaleStaffID");

                    b.HasIndex(new[] { "ShipperId" }, "IX_Order_ShipperID");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderDetailID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"), 1L, 1);

                    b.Property<decimal?>("CustomizedAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CustomizedSize")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("FinalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex(new[] { "OrderId" }, "IX_OrderDetail_OrderID");

                    b.HasIndex(new[] { "ProductId" }, "IX_OrderDetail_ProductID");

                    b.ToTable("OrderDetail", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PaymentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<decimal?>("Deposits")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<string>("PayDetail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PayMethod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PaymentId");

                    b.HasIndex(new[] { "CustomerId" }, "IX_Payment_CustomerID");

                    b.HasIndex(new[] { "OrderId" }, "IX_Payment_OrderID");

                    b.ToTable("Payment", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal?>("DifferentCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("GemCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<decimal?>("MaterialCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PriceRate")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductSize")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("ProductionCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex(new[] { "CategoryId" }, "IX_Product_CategoryID");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId")
                        .HasName("PK__ProductC__19093A2B9D6C05A5");

                    b.ToTable("ProductCategory", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.ProductMaterial", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int")
                        .HasColumnName("MaterialID");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "MaterialId")
                        .HasName("PK__ProductM__D85CA7DC6CDE5C71");

                    b.HasIndex(new[] { "MaterialId" }, "IX_ProductMaterial_MaterialID");

                    b.ToTable("ProductMaterial", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.staff", b =>
                {
                    b.Property<string>("StaffId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("StaffID");

                    b.Property<int?>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("AccountID");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StaffId");

                    b.HasIndex(new[] { "AccountId" }, "UQ__Staff__349DA5870B6A8E6C")
                        .IsUnique()
                        .HasFilter("([AccountID] IS NOT NULL)");

                    b.ToTable("Staff", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.Warranty", b =>
                {
                    b.Property<int>("WarrantyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WarrantyID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarrantyId"), 1L, 1);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<int?>("OrderDetailId")
                        .HasColumnType("int")
                        .HasColumnName("OrderDetailID");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("WarrantyId");

                    b.HasIndex(new[] { "OrderDetailId" }, "UQ__Warranty__D3B9D30DBA9C9B64")
                        .IsUnique()
                        .HasFilter("([OrderDetailID] IS NOT NULL)");

                    b.ToTable("Warranty", (string)null);
                });

            modelBuilder.Entity("ProductGem", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int>("GemId")
                        .HasColumnType("int")
                        .HasColumnName("GemID");

                    b.HasKey("ProductId", "GemId")
                        .HasName("PK__ProductG__AB1CDBB789957F43");

                    b.HasIndex(new[] { "GemId" }, "IX_ProductGem_GemID");

                    b.ToTable("ProductGem", (string)null);
                });

            modelBuilder.Entity("BusinessObjects.Models.Customer", b =>
                {
                    b.HasOne("BusinessObjects.Models.Account", "Account")
                        .WithOne("Customer")
                        .HasForeignKey("BusinessObjects.Models.Customer", "AccountId")
                        .HasConstraintName("FK__Customer__Accoun__3A81B327");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BusinessObjects.Models.CustomerAddress", b =>
                {
                    b.HasOne("BusinessObjects.Models.Customer", "Customer")
                        .WithMany("CustomerAddresses")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__CustomerA__Custo__412EB0B6");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BusinessObjects.Models.DiamondGradingReport", b =>
                {
                    b.HasOne("BusinessObjects.Models.Gem", "Gem")
                        .WithOne("DiamondGradingReport")
                        .HasForeignKey("BusinessObjects.Models.DiamondGradingReport", "GemId")
                        .HasConstraintName("FK__DiamondGr__GemID__5CD6CB2B");

                    b.Navigation("Gem");
                });

            modelBuilder.Entity("BusinessObjects.Models.MaterialPriceList", b =>
                {
                    b.HasOne("BusinessObjects.Models.Material", "Material")
                        .WithMany("MaterialPriceLists")
                        .HasForeignKey("MaterialId")
                        .HasConstraintName("FK__MaterialP__Mater__4AB81AF0");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("BusinessObjects.Models.Membership", b =>
                {
                    b.HasOne("BusinessObjects.Models.Customer", "Customer")
                        .WithOne("Membership")
                        .HasForeignKey("BusinessObjects.Models.Membership", "CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK__Membershi__Custo__440B1D61");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BusinessObjects.Models.Order", b =>
                {
                    b.HasOne("BusinessObjects.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Order__CustomerI__5FB337D6");

                    b.HasOne("BusinessObjects.Models.staff", "SaleStaff")
                        .WithMany("OrderSaleStaffs")
                        .HasForeignKey("SaleStaffId")
                        .HasConstraintName("FK__Order__SaleStaff__60A75C0F");

                    b.HasOne("BusinessObjects.Models.staff", "Shipper")
                        .WithMany("OrderShippers")
                        .HasForeignKey("ShipperId")
                        .HasConstraintName("FK__Order__ShipperID__619B8048");

                    b.Navigation("Customer");

                    b.Navigation("SaleStaff");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("BusinessObjects.Models.OrderDetail", b =>
                {
                    b.HasOne("BusinessObjects.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__OrderDeta__Order__6477ECF3");

                    b.HasOne("BusinessObjects.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__OrderDeta__Produ__656C112C");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BusinessObjects.Models.Payment", b =>
                {
                    b.HasOne("BusinessObjects.Models.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Payment__Custome__6D0D32F4");

                    b.HasOne("BusinessObjects.Models.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__Payment__OrderID__6C190EBB");

                    b.Navigation("Customer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BusinessObjects.Models.Product", b =>
                {
                    b.HasOne("BusinessObjects.Models.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Product__Categor__4D94879B");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BusinessObjects.Models.ProductMaterial", b =>
                {
                    b.HasOne("BusinessObjects.Models.Material", "Material")
                        .WithMany("ProductMaterials")
                        .HasForeignKey("MaterialId")
                        .IsRequired()
                        .HasConstraintName("FK__ProductMa__Mater__5165187F");

                    b.HasOne("BusinessObjects.Models.Product", "Product")
                        .WithMany("ProductMaterials")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK__ProductMa__Produ__5070F446");

                    b.Navigation("Material");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BusinessObjects.Models.staff", b =>
                {
                    b.HasOne("BusinessObjects.Models.Account", "Account")
                        .WithOne("staff")
                        .HasForeignKey("BusinessObjects.Models.staff", "AccountId")
                        .HasConstraintName("FK__Staff__AccountID__3E52440B");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BusinessObjects.Models.Warranty", b =>
                {
                    b.HasOne("BusinessObjects.Models.OrderDetail", "OrderDetail")
                        .WithOne("Warranty")
                        .HasForeignKey("BusinessObjects.Models.Warranty", "OrderDetailId")
                        .HasConstraintName("FK__Warranty__OrderD__693CA210");

                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("ProductGem", b =>
                {
                    b.HasOne("BusinessObjects.Models.Gem", null)
                        .WithMany()
                        .HasForeignKey("GemId")
                        .IsRequired()
                        .HasConstraintName("FK__ProductGe__GemID__59063A47");

                    b.HasOne("BusinessObjects.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK__ProductGe__Produ__5812160E");
                });

            modelBuilder.Entity("BusinessObjects.Models.Account", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("staff");
                });

            modelBuilder.Entity("BusinessObjects.Models.Customer", b =>
                {
                    b.Navigation("CustomerAddresses");

                    b.Navigation("Membership");

                    b.Navigation("Orders");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("BusinessObjects.Models.Gem", b =>
                {
                    b.Navigation("DiamondGradingReport");
                });

            modelBuilder.Entity("BusinessObjects.Models.Material", b =>
                {
                    b.Navigation("MaterialPriceLists");

                    b.Navigation("ProductMaterials");
                });

            modelBuilder.Entity("BusinessObjects.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("BusinessObjects.Models.OrderDetail", b =>
                {
                    b.Navigation("Warranty");
                });

            modelBuilder.Entity("BusinessObjects.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ProductMaterials");
                });

            modelBuilder.Entity("BusinessObjects.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BusinessObjects.Models.staff", b =>
                {
                    b.Navigation("OrderSaleStaffs");

                    b.Navigation("OrderShippers");
                });
#pragma warning restore 612, 618
        }
    }
}
