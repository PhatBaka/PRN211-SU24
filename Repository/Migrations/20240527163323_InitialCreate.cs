using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "Gem",
                columns: table => new
                {
                    GemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Polish = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Symmetry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fluorescence = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CaratWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cut = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Clarity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Shape = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gem", x => x.GemID);
                });

            migrationBuilder.CreateTable(
                name: "GemPriceList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CaratWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Clarity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cut = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EffDate = table.Column<DateTime>(type: "date", nullable: true),
                    Size = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GemPriceList", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.MaterialID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProductC__19093A2B9D6C05A5", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Birthday = table.Column<DateTime>(type: "date", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK__Customer__Accoun__3A81B327",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "AccountID");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK__Staff__AccountID__3E52440B",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "AccountID");
                });

            migrationBuilder.CreateTable(
                name: "DiamondGradingReport",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GemID = table.Column<int>(type: "int", nullable: true),
                    GenerateDate = table.Column<DateTime>(type: "date", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DiamondG__D5BD48E5B3590D2D", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK__DiamondGr__GemID__5CD6CB2B",
                        column: x => x.GemID,
                        principalTable: "Gem",
                        principalColumn: "GemID");
                });

            migrationBuilder.CreateTable(
                name: "MaterialPriceList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialID = table.Column<int>(type: "int", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EffDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialPriceList", x => x.ID);
                    table.ForeignKey(
                        name: "FK__MaterialP__Mater__4AB81AF0",
                        column: x => x.MaterialID,
                        principalTable: "Material",
                        principalColumn: "MaterialID");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    MaterialCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GemCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DifferentCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductionCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PriceRate = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    ProductSize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK__Product__Categor__4D94879B",
                        column: x => x.CategoryID,
                        principalTable: "ProductCategory",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__091C2A1B4CF188D0", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK__CustomerA__Custo__412EB0B6",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(5,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Membersh__A4AE64B8AB77A18A", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK__Membershi__Custo__440B1D61",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PayMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShippingStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShippingDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "date", nullable: true),
                    SaleStaffID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ShipperID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK__Order__CustomerI__5FB337D6",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK__Order__SaleStaff__60A75C0F",
                        column: x => x.SaleStaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID");
                    table.ForeignKey(
                        name: "FK__Order__ShipperID__619B8048",
                        column: x => x.ShipperID,
                        principalTable: "Staff",
                        principalColumn: "StaffID");
                });

            migrationBuilder.CreateTable(
                name: "ProductGem",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    GemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProductG__AB1CDBB789957F43", x => new { x.ProductID, x.GemID });
                    table.ForeignKey(
                        name: "FK__ProductGe__GemID__59063A47",
                        column: x => x.GemID,
                        principalTable: "Gem",
                        principalColumn: "GemID");
                    table.ForeignKey(
                        name: "FK__ProductGe__Produ__5812160E",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterial",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProductM__D85CA7DC6CDE5C71", x => new { x.ProductID, x.MaterialID });
                    table.ForeignKey(
                        name: "FK__ProductMa__Mater__5165187F",
                        column: x => x.MaterialID,
                        principalTable: "Material",
                        principalColumn: "MaterialID");
                    table.ForeignKey(
                        name: "FK__ProductMa__Produ__5070F446",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    CustomizedSize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomizedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FinalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK__OrderDeta__Order__6477ECF3",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK__OrderDeta__Produ__656C112C",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    PayMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deposits = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PayDetail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK__Payment__Custome__6D0D32F4",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK__Payment__OrderID__6C190EBB",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID");
                });

            migrationBuilder.CreateTable(
                name: "Warranty",
                columns: table => new
                {
                    WarrantyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDetailID = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranty", x => x.WarrantyID);
                    table.ForeignKey(
                        name: "FK__Warranty__OrderD__693CA210",
                        column: x => x.OrderDetailID,
                        principalTable: "OrderDetail",
                        principalColumn: "OrderDetailID");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Customer__349DA5874099DCFA",
                table: "Customer",
                column: "AccountID",
                unique: true,
                filter: "([AccountID] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerID",
                table: "CustomerAddress",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "UQ__DiamondG__F101D5A197EBDB87",
                table: "DiamondGradingReport",
                column: "GemID",
                unique: true,
                filter: "([GemID] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialPriceList_MaterialID",
                table: "MaterialPriceList",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SaleStaffID",
                table: "Order",
                column: "SaleStaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShipperID",
                table: "Order",
                column: "ShipperID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderID",
                table: "OrderDetail",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductID",
                table: "OrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerID",
                table: "Payment",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderID",
                table: "Payment",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGem_GemID",
                table: "ProductGem",
                column: "GemID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterial_MaterialID",
                table: "ProductMaterial",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "UQ__Staff__349DA5870B6A8E6C",
                table: "Staff",
                column: "AccountID",
                unique: true,
                filter: "([AccountID] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "UQ__Warranty__D3B9D30DBA9C9B64",
                table: "Warranty",
                column: "OrderDetailID",
                unique: true,
                filter: "([OrderDetailID] IS NOT NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "DiamondGradingReport");

            migrationBuilder.DropTable(
                name: "GemPriceList");

            migrationBuilder.DropTable(
                name: "MaterialPriceList");

            migrationBuilder.DropTable(
                name: "Membership");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "ProductGem");

            migrationBuilder.DropTable(
                name: "ProductMaterial");

            migrationBuilder.DropTable(
                name: "Warranty");

            migrationBuilder.DropTable(
                name: "Gem");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
