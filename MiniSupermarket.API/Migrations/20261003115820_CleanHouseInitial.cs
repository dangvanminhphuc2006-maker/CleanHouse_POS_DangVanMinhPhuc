using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class CleanHouseInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OriginRegion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RewardPoints = table.Column<int>(type: "int", nullable: false),
                    MembershipRank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.PromotionId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OriginRegion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    MinStockQuantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId");
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "InventoryLogs",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    QuantityChange = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryLogs", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_InventoryLogs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryLogs_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "Description", "OriginRegion" },
                values: new object[,]
                {
                    { 1, "OMO", "Thương hiệu nước giặt và sản phẩm giặt tẩy", "Việt Nam" },
                    { 2, "Comfort", "Thương hiệu nước xả vải", "Việt Nam" },
                    { 3, "Sunlight", "Thương hiệu nước rửa chén", "Việt Nam" },
                    { 4, "Vim", "Thương hiệu sản phẩm vệ sinh nhà cửa", "Việt Nam" },
                    { 5, "Gift", "Thương hiệu nước giặt và chất tẩy rửa", "Việt Nam" },
                    { 6, "Lix", "Thương hiệu hóa phẩm gia dụng", "Việt Nam" },
                    { 7, "Cif", "Sản phẩm vệ sinh bề mặt", "Việt Nam" },
                    { 8, "Harpic", "Sản phẩm vệ sinh nhà tắm", "Việt Nam" },
                    { 9, "Downy", "Thương hiệu nước xả vải", "Việt Nam" },
                    { 10, "Duck", "Sản phẩm vệ sinh toilet", "Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Nước giặt", "Nước giặt quần áo dạng nước" },
                    { 2, "Bột giặt", "Bột giặt dùng cho giặt tay và máy giặt" },
                    { 3, "Nước xả vải", "Nước xả và làm mềm vải" },
                    { 4, "Nước rửa chén", "Nước rửa chén và dụng cụ nhà bếp" },
                    { 5, "Nước lau sàn", "Dung dịch vệ sinh sàn nhà" },
                    { 6, "Nước lau kính", "Dung dịch làm sạch kính và bề mặt" },
                    { 7, "Nước tẩy toilet", "Sản phẩm vệ sinh và khử khuẩn toilet" },
                    { 8, "Chất tẩy rửa", "Các sản phẩm tẩy rửa gia dụng" },
                    { 9, "Dung dịch vệ sinh", "Dung dịch vệ sinh các khu vực trong nhà" },
                    { 10, "Dụng cụ vệ sinh", "Chổi, khăn, miếng rửa và dụng cụ vệ sinh" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber", "RewardPoints" },
                values: new object[,]
                {
                    { 1, "Quận 1, TP.HCM", "Nguyễn Văn An", "Vàng", "0901122334", 210 },
                    { 2, "Quận 5, TP.HCM", "Trần Thị Bình", "Bạc", "0918877665", 85 },
                    { 3, "Quận 3, TP.HCM", "Lê Văn Cường", "Chuẩn", "0983344556", 25 },
                    { 4, "Quận 10, TP.HCM", "Phạm Thị Dung", "Kim Cương", "0934567890", 540 },
                    { 5, "Quận Phú Nhuận, TP.HCM", "Hoàng Minh Đức", "Bạc", "0971122444", 110 }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionId", "Code", "Description", "DiscountAmount", "DiscountPercent", "EndDate", "IsActive", "StartDate" },
                values: new object[,]
                {
                    { 1, "CLEAN10K", "Giảm 10.000 VNĐ cho đơn hàng từ 200.000 VNĐ", 10000m, 0.0, new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "GIAT5", "Giảm 5% cho nhóm nước giặt và bột giặt", 0m, 5.0, new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "HOUSE10", "Giảm 10% cho một số sản phẩm vệ sinh nhà cửa", 0m, 10.0, new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "ContactName", "OriginRegion", "PhoneNumber", "SupplierName" },
                values: new object[,]
                {
                    { 1, "Khu công nghiệp Tây Bắc Củ Chi, TP.HCM", "Nguyễn Văn Hùng", "TP.HCM", "0988111222", "Công ty TNHH Unilever Việt Nam" },
                    { 2, "Quận Thủ Đức, TP.HCM", "Trần Thu Hà", "TP.HCM", "0912333444", "Công ty Cổ phần LIXCO" },
                    { 3, "Quận Bình Tân, TP.HCM", "Lê Minh Tuấn", "TP.HCM", "0903555666", "Công ty Hóa phẩm Việt" },
                    { 4, "Quận Tân Bình, TP.HCM", "Phạm Quốc Bảo", "TP.HCM", "02633888777", "Nhà phân phối Clean House" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FullName", "IsActive", "PasswordHash", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "Đặng Văn Minh Phúc - Quản lý", true, "admin123_hash", "Admin", "admin" },
                    { 2, "Nhân viên Thu ngân", true, "cashier123_hash", "Cashier", "cashier01" },
                    { 3, "Nhân viên Kho", true, "warehouse123_hash", "Warehouse", "warehouse01" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "PaymentMethod", "PaymentStatus", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 9, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), "Cash", "Paid", 197000m },
                    { 2, 2, new DateTime(2026, 9, 22, 14, 15, 0, 0, DateTimeKind.Unspecified), "QR Code", "Paid", 142000m },
                    { 3, 4, new DateTime(2026, 9, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "Banking", "Paid", 320000m },
                    { 4, 3, new DateTime(2026, 9, 27, 16, 45, 0, 0, DateTimeKind.Unspecified), "Cash", "Paid", 96000m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Barcode", "BrandId", "CategoryId", "CostPrice", "ImageUrl", "IsActive", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[,]
                {
                    { 1, "8934868000001", 1, 1, 140000m, null, true, 5, 165000m, "Nước giặt OMO Matic 3.6kg", 30, "Can" },
                    { 2, "8934868000002", 1, 1, 120000m, null, true, 5, 145000m, "Nước giặt OMO Comfort tinh dầu 2.8kg", 25, "Can" },
                    { 3, "8934868000003", 6, 2, 70000m, null, true, 8, 85000m, "Bột giặt Lix Extra 3kg", 40, "Túi" },
                    { 4, "8934868000004", 2, 3, 78000m, null, true, 8, 95000m, "Nước xả Comfort 1.8L", 35, "Chai" },
                    { 5, "8934868000005", 9, 3, 90000m, null, true, 6, 110000m, "Nước xả Downy 1.7L", 28, "Chai" },
                    { 6, "8934868000006", 3, 4, 26000m, null, true, 10, 32000m, "Nước rửa chén Sunlight 750ml", 60, "Chai" },
                    { 7, "8934868000007", 5, 5, 34000m, null, true, 10, 42000m, "Nước lau sàn Gift 1L", 45, "Chai" },
                    { 8, "8934868000008", 7, 6, 39000m, null, true, 6, 48000m, "Nước lau kính Cif 500ml", 32, "Chai" },
                    { 9, "8934868000009", 4, 7, 42000m, null, true, 8, 52000m, "Nước tẩy toilet Vim 900ml", 38, "Chai" },
                    { 10, "8934868000010", 6, 8, 22000m, null, true, 10, 28000m, "Nước tẩy Javel Lix 1L", 50, "Chai" },
                    { 11, "8934868000011", 7, 9, 52000m, null, true, 5, 65000m, "Dung dịch vệ sinh Cif 500ml", 25, "Chai" },
                    { 12, "8934868000012", 8, 7, 44000m, null, true, 6, 55000m, "Gel tẩy bồn cầu Harpic 450ml", 30, "Chai" },
                    { 13, "8934868000013", null, 10, 18000m, null, true, 15, 25000m, "Khăn lau đa năng Clean House", 70, "Gói" },
                    { 14, "8934868000014", null, 10, 12000m, null, true, 15, 18000m, "Miếng rửa chén Clean House 5 cái", 80, "Gói" },
                    { 15, "8934868000015", 5, 5, 55000m, null, true, 5, 68000m, "Nước lau sàn Gift hương chanh 2L", 22, "Chai" }
                });

            migrationBuilder.InsertData(
                table: "InventoryLogs",
                columns: new[] { "LogId", "BatchNumber", "ExpirationDate", "Note", "ProductId", "QuantityChange", "SupplierId", "TransactionDate", "TransactionType" },
                values: new object[,]
                {
                    { 1, "LOT-OMO-20260901", new DateTime(2029, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhập kho nước giặt OMO", 1, 40, null, new DateTime(2026, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "IMPORT" },
                    { 2, "LOT-SUN-20260905", new DateTime(2029, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhập kho nước rửa chén Sunlight", 6, 80, null, new DateTime(2026, 9, 5, 9, 30, 0, 0, DateTimeKind.Unspecified), "IMPORT" },
                    { 3, "LOT-VIM-20260820", new DateTime(2029, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Điều chỉnh hao hụt kiểm kê", 9, -2, null, new DateTime(2026, 9, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "ADJUSTMENT" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 165000m },
                    { 2, 1, 6, 1, 32000m },
                    { 3, 2, 4, 1, 95000m },
                    { 4, 2, 6, 1, 32000m },
                    { 5, 2, 14, 1, 18000m },
                    { 6, 3, 2, 1, 145000m },
                    { 7, 3, 5, 1, 110000m },
                    { 8, 3, 9, 1, 52000m },
                    { 9, 3, 13, 1, 25000m },
                    { 10, 4, 7, 1, 42000m },
                    { 11, 4, 10, 1, 28000m },
                    { 12, 4, 14, 1, 18000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLogs_ProductId",
                table: "InventoryLogs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLogs_SupplierId",
                table: "InventoryLogs",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryLogs");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
