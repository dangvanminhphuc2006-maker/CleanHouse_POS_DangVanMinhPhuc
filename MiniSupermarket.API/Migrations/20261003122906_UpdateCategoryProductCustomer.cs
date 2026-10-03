using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryProductCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryLogs",
                keyColumn: "LogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryLogs",
                keyColumn: "LogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InventoryLogs",
                keyColumn: "LogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Nước giặt quần áo");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Description",
                value: "Bột giặt quần áo");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Description",
                value: "Nước rửa chén và bát");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "Description",
                value: "Nước vệ sinh sàn nhà");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "Description",
                value: "Dung dịch lau kính");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "Description",
                value: "Nước tẩy và vệ sinh toilet");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "Description",
                value: "Các loại chất tẩy rửa");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "Description",
                value: "Dung dịch vệ sinh nhà cửa");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Khăn lau", "Khăn lau vệ sinh các bề mặt" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 11, "Miếng rửa chén", "Miếng rửa chén và dụng cụ nhà bếp" },
                    { 12, "Bàn chải vệ sinh", "Bàn chải dùng trong vệ sinh" },
                    { 13, "Cây lau nhà", "Các loại cây lau nhà" },
                    { 14, "Bao tay vệ sinh", "Bao tay dùng khi vệ sinh" },
                    { 15, "Túi rác", "Các loại túi đựng rác gia dụng" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Address",
                value: "123 Đường Nguyễn Trãi, Q.1");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Address",
                value: "456 Đường Trần Hưng Đạo, Q.5");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "Address",
                value: "78 Đường Võ Văn Tần, Q.3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                column: "Address",
                value: "12 Đường Thành Thái, Q.10");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                column: "Address",
                value: "89 Đường Phan Đăng Lưu, Q.Phú Nhuận");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber", "RewardPoints" },
                values: new object[,]
                {
                    { 6, "204 Đường Điện Biên Phủ, Q.3", "Đỗ Thu Hà", "Chuẩn", "0909988776", 15 },
                    { 7, "55 Đường Xô Viết Nghệ Tĩnh, Q.Bình Thạnh", "Vũ Quốc Hùng", "Vàng", "0945112233", 320 },
                    { 8, "15 Đường Nguyễn Xí, Q.Bình Thạnh", "Đặng Mai Hương", "Chuẩn", "0966778899", 0 },
                    { 9, "88 Đường 3 Tháng 2, Q.10", "Bùi Anh Khoa", "Bạc", "0931223344", 95 },
                    { 10, "302 Đường Nguyễn Đình Chiểu, Q.3", "Ngô Bích Ngọc", "Vàng", "0978990011", 280 },
                    { 11, "12 Đường Lê Thị Hồng Gấm, Q.1", "Trịnh Quốc Bảo", "Chuẩn", "0903445566", 40 },
                    { 12, "74 Đường Lý Thường Kiệt, Q.10", "Lý Mỹ Duyên", "Kim Cương", "0915667788", 610 },
                    { 13, "450 Đường Điện Biên Phủ, Q.Bình Thạnh", "Đoàn Tấn Phát", "Bạc", "0982114455", 130 },
                    { 14, "19 Đường Nguyễn Văn Cừ, Q.5", "Dương Khánh Linh", "Chuẩn", "0947889900", 10 },
                    { 15, "500 Đường Cộng Hòa, Q.Tân Bình", "Phan Hoài Nam", "Vàng", "0963221100", 190 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 6, 2, 70000m, 8, 85000m, "Bột giặt Lix Extra 3kg", 40, "Túi" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 2, 3, 78000m, 95000m, "Nước xả Comfort 1.8L", 35, "Chai" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "BrandId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 9, 90000m, 6, 110000m, "Nước xả Downy 1.7L", 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 3, 4, 26000m, 10, 32000m, "Nước rửa chén Sunlight 750ml", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 5, 5, 34000m, 42000m, "Nước lau sàn Gift 1L", 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 7, 6, 39000m, 6, 48000m, "Nước lau kính Cif 500ml", 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 4, 7, 42000m, 8, 52000m, "Nước tẩy toilet Vim 900ml", 38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 6, 8, 22000m, 10, 28000m, "Nước tẩy Javel Lix 1L", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 7, 9, 52000m, 5, 65000m, "Dung dịch vệ sinh Cif 500ml", 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { null, 10, 18000m, 15, 25000m, "Khăn lau đa năng Clean House", 70, "Gói" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { null, 11, 12000m, 15, 18000m, "Miếng rửa chén Clean House 5 cái", 80, "Gói" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 12, 15000m, 10, 22000m, "Bàn chải vệ sinh Clean House", 50, "Cái" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 13, 95000m, 5, 125000m, "Cây lau nhà Clean House", 20, "Cây" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { null, 15, 25000m, 10, 35000m, "Túi rác tự phân hủy 55x65cm", 45, "Cuộn" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Nước giặt quần áo dạng nước");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Description",
                value: "Bột giặt dùng cho giặt tay và máy giặt");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Description",
                value: "Nước rửa chén và dụng cụ nhà bếp");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "Description",
                value: "Dung dịch vệ sinh sàn nhà");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "Description",
                value: "Dung dịch làm sạch kính và bề mặt");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "Description",
                value: "Sản phẩm vệ sinh và khử khuẩn toilet");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "Description",
                value: "Các sản phẩm tẩy rửa gia dụng");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "Description",
                value: "Dung dịch vệ sinh các khu vực trong nhà");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Dụng cụ vệ sinh", "Chổi, khăn, miếng rửa và dụng cụ vệ sinh" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Address",
                value: "Quận 1, TP.HCM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Address",
                value: "Quận 5, TP.HCM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "Address",
                value: "Quận 3, TP.HCM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                column: "Address",
                value: "Quận 10, TP.HCM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                column: "Address",
                value: "Quận Phú Nhuận, TP.HCM");

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
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "PaymentMethod", "PaymentStatus", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 9, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), "Cash", "Paid", 197000m },
                    { 2, 2, new DateTime(2026, 9, 22, 14, 15, 0, 0, DateTimeKind.Unspecified), "QR Code", "Paid", 142000m },
                    { 3, 4, new DateTime(2026, 9, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "Banking", "Paid", 320000m },
                    { 4, 3, new DateTime(2026, 9, 27, 16, 45, 0, 0, DateTimeKind.Unspecified), "Cash", "Paid", 96000m }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 1, 1, 120000m, 5, 145000m, "Nước giặt OMO Comfort tinh dầu 2.8kg", 25, "Can" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 6, 2, 70000m, 85000m, "Bột giặt Lix Extra 3kg", 40, "Túi" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "BrandId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 2, 78000m, 8, 95000m, "Nước xả Comfort 1.8L", 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 9, 3, 90000m, 6, 110000m, "Nước xả Downy 1.7L", 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 3, 4, 26000m, 32000m, "Nước rửa chén Sunlight 750ml", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 5, 5, 34000m, 10, 42000m, "Nước lau sàn Gift 1L", 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 7, 6, 39000m, 6, 48000m, "Nước lau kính Cif 500ml", 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 4, 7, 42000m, 8, 52000m, "Nước tẩy toilet Vim 900ml", 38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 6, 8, 22000m, 10, 28000m, "Nước tẩy Javel Lix 1L", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 7, 9, 52000m, 5, 65000m, "Dung dịch vệ sinh Cif 500ml", 25, "Chai" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 8, 7, 44000m, 6, 55000m, "Gel tẩy bồn cầu Harpic 450ml", 30, "Chai" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 10, 18000m, 15, 25000m, "Khăn lau đa năng Clean House", 70, "Gói" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 10, 12000m, 15, 18000m, "Miếng rửa chén Clean House 5 cái", 80, "Gói" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "BrandId", "CategoryId", "CostPrice", "MinStockQuantity", "Price", "ProductName", "StockQuantity", "Unit" },
                values: new object[] { 5, 5, 55000m, 5, 68000m, "Nước lau sàn Gift hương chanh 2L", 22, "Chai" });

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
        }
    }
}
