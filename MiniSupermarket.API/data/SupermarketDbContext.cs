using Microsoft.EntityFrameworkCore;
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Data
{
    public class SupermarketDbContext : DbContext
    {
        public SupermarketDbContext(
            DbContextOptions<SupermarketDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<InventoryLog> InventoryLogs { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ==========================================
            // 1. THƯƠNG HIỆU
            // ==========================================
            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    BrandId = 1,
                    BrandName = "OMO",
                    OriginRegion = "Việt Nam",
                    Description = "Thương hiệu nước giặt và sản phẩm giặt tẩy"
                },
                new Brand
                {
                    BrandId = 2,
                    BrandName = "Comfort",
                    OriginRegion = "Việt Nam",
                    Description = "Thương hiệu nước xả vải"
                },
                new Brand
                {
                    BrandId = 3,
                    BrandName = "Sunlight",
                    OriginRegion = "Việt Nam",
                    Description = "Thương hiệu nước rửa chén"
                },
                new Brand
                {
                    BrandId = 4,
                    BrandName = "Vim",
                    OriginRegion = "Việt Nam",
                    Description = "Thương hiệu sản phẩm vệ sinh nhà cửa"
                },
                new Brand
                {
                    BrandId = 5,
                    BrandName = "Gift",
                    OriginRegion = "Việt Nam",
                    Description = "Thương hiệu nước giặt và chất tẩy rửa"
                },
                new Brand
                {
                    BrandId = 6,
                    BrandName = "Lix",
                    OriginRegion = "Việt Nam",
                    Description = "Thương hiệu hóa phẩm gia dụng"
                },
                new Brand
                {
                    BrandId = 7,
                    BrandName = "Cif",
                    OriginRegion = "Việt Nam",
                    Description = "Sản phẩm vệ sinh bề mặt"
                },
                new Brand
                {
                    BrandId = 8,
                    BrandName = "Harpic",
                    OriginRegion = "Việt Nam",
                    Description = "Sản phẩm vệ sinh nhà tắm"
                },
                new Brand
                {
                    BrandId = 9,
                    BrandName = "Downy",
                    OriginRegion = "Việt Nam",
                    Description = "Thương hiệu nước xả vải"
                },
                new Brand
                {
                    BrandId = 10,
                    BrandName = "Duck",
                    OriginRegion = "Việt Nam",
                    Description = "Sản phẩm vệ sinh toilet"
                }
            );

            // ==========================================
            // 2. DANH MỤC SẢN PHẨM
            // ==========================================
            // =====================================================
            // 2. CATEGORY - 15 DANH MỤC
            // =====================================================
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Nước giặt", Description = "Nước giặt quần áo" },
                new Category { CategoryId = 2, CategoryName = "Bột giặt", Description = "Bột giặt quần áo" },
                new Category { CategoryId = 3, CategoryName = "Nước xả vải", Description = "Nước xả và làm mềm vải" },
                new Category { CategoryId = 4, CategoryName = "Nước rửa chén", Description = "Nước rửa chén và bát" },
                new Category { CategoryId = 5, CategoryName = "Nước lau sàn", Description = "Nước vệ sinh sàn nhà" },
                new Category { CategoryId = 6, CategoryName = "Nước lau kính", Description = "Dung dịch lau kính" },
                new Category { CategoryId = 7, CategoryName = "Nước tẩy toilet", Description = "Nước tẩy và vệ sinh toilet" },
                new Category { CategoryId = 8, CategoryName = "Chất tẩy rửa", Description = "Các loại chất tẩy rửa" },
                new Category { CategoryId = 9, CategoryName = "Dung dịch vệ sinh", Description = "Dung dịch vệ sinh nhà cửa" },
                new Category { CategoryId = 10, CategoryName = "Khăn lau", Description = "Khăn lau vệ sinh các bề mặt" },
                new Category { CategoryId = 11, CategoryName = "Miếng rửa chén", Description = "Miếng rửa chén và dụng cụ nhà bếp" },
                new Category { CategoryId = 12, CategoryName = "Bàn chải vệ sinh", Description = "Bàn chải dùng trong vệ sinh" },
                new Category { CategoryId = 13, CategoryName = "Cây lau nhà", Description = "Các loại cây lau nhà" },
                new Category { CategoryId = 14, CategoryName = "Bao tay vệ sinh", Description = "Bao tay dùng khi vệ sinh" },
                new Category { CategoryId = 15, CategoryName = "Túi rác", Description = "Các loại túi đựng rác gia dụng" }
            );


            // =====================================================
            // 3. PRODUCT - 15 SẢN PHẨM
            // =====================================================
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Barcode = "8934868000001",
                    ProductName = "Nước giặt OMO Matic 3.6kg",
                    Unit = "Can",
                    Price = 165000,
                    CostPrice = 140000,
                    StockQuantity = 30,
                    MinStockQuantity = 5,
                    IsActive = true,
                    CategoryId = 1,
                    BrandId = 1
                },

                new Product
                {
                    ProductId = 2,
                    Barcode = "8934868000002",
                    ProductName = "Bột giặt Lix Extra 3kg",
                    Unit = "Túi",
                    Price = 85000,
                    CostPrice = 70000,
                    StockQuantity = 40,
                    MinStockQuantity = 8,
                    IsActive = true,
                    CategoryId = 2,
                    BrandId = 6
                },

                new Product
                {
                    ProductId = 3,
                    Barcode = "8934868000003",
                    ProductName = "Nước xả Comfort 1.8L",
                    Unit = "Chai",
                    Price = 95000,
                    CostPrice = 78000,
                    StockQuantity = 35,
                    MinStockQuantity = 8,
                    IsActive = true,
                    CategoryId = 3,
                    BrandId = 2
                },

                new Product
                {
                    ProductId = 4,
                    Barcode = "8934868000004",
                    ProductName = "Nước xả Downy 1.7L",
                    Unit = "Chai",
                    Price = 110000,
                    CostPrice = 90000,
                    StockQuantity = 28,
                    MinStockQuantity = 6,
                    IsActive = true,
                    CategoryId = 3,
                    BrandId = 9
                },

                new Product
                {
                    ProductId = 5,
                    Barcode = "8934868000005",
                    ProductName = "Nước rửa chén Sunlight 750ml",
                    Unit = "Chai",
                    Price = 32000,
                    CostPrice = 26000,
                    StockQuantity = 60,
                    MinStockQuantity = 10,
                    IsActive = true,
                    CategoryId = 4,
                    BrandId = 3
                },

                new Product
                {
                    ProductId = 6,
                    Barcode = "8934868000006",
                    ProductName = "Nước lau sàn Gift 1L",
                    Unit = "Chai",
                    Price = 42000,
                    CostPrice = 34000,
                    StockQuantity = 45,
                    MinStockQuantity = 10,
                    IsActive = true,
                    CategoryId = 5,
                    BrandId = 5
                },

                new Product
                {
                    ProductId = 7,
                    Barcode = "8934868000007",
                    ProductName = "Nước lau kính Cif 500ml",
                    Unit = "Chai",
                    Price = 48000,
                    CostPrice = 39000,
                    StockQuantity = 32,
                    MinStockQuantity = 6,
                    IsActive = true,
                    CategoryId = 6,
                    BrandId = 7
                },

                new Product
                {
                    ProductId = 8,
                    Barcode = "8934868000008",
                    ProductName = "Nước tẩy toilet Vim 900ml",
                    Unit = "Chai",
                    Price = 52000,
                    CostPrice = 42000,
                    StockQuantity = 38,
                    MinStockQuantity = 8,
                    IsActive = true,
                    CategoryId = 7,
                    BrandId = 4
                },

                new Product
                {
                    ProductId = 9,
                    Barcode = "8934868000009",
                    ProductName = "Nước tẩy Javel Lix 1L",
                    Unit = "Chai",
                    Price = 28000,
                    CostPrice = 22000,
                    StockQuantity = 50,
                    MinStockQuantity = 10,
                    IsActive = true,
                    CategoryId = 8,
                    BrandId = 6
                },

                new Product
                {
                    ProductId = 10,
                    Barcode = "8934868000010",
                    ProductName = "Dung dịch vệ sinh Cif 500ml",
                    Unit = "Chai",
                    Price = 65000,
                    CostPrice = 52000,
                    StockQuantity = 25,
                    MinStockQuantity = 5,
                    IsActive = true,
                    CategoryId = 9,
                    BrandId = 7
                },

                new Product
                {
                    ProductId = 11,
                    Barcode = "8934868000011",
                    ProductName = "Khăn lau đa năng Clean House",
                    Unit = "Gói",
                    Price = 25000,
                    CostPrice = 18000,
                    StockQuantity = 70,
                    MinStockQuantity = 15,
                    IsActive = true,
                    CategoryId = 10,
                    BrandId = null
                },

                new Product
                {
                    ProductId = 12,
                    Barcode = "8934868000012",
                    ProductName = "Miếng rửa chén Clean House 5 cái",
                    Unit = "Gói",
                    Price = 18000,
                    CostPrice = 12000,
                    StockQuantity = 80,
                    MinStockQuantity = 15,
                    IsActive = true,
                    CategoryId = 11,
                    BrandId = null
                },

                new Product
                {
                    ProductId = 13,
                    Barcode = "8934868000013",
                    ProductName = "Bàn chải vệ sinh Clean House",
                    Unit = "Cái",
                    Price = 22000,
                    CostPrice = 15000,
                    StockQuantity = 50,
                    MinStockQuantity = 10,
                    IsActive = true,
                    CategoryId = 12,
                    BrandId = null
                },

                new Product
                {
                    ProductId = 14,
                    Barcode = "8934868000014",
                    ProductName = "Cây lau nhà Clean House",
                    Unit = "Cây",
                    Price = 125000,
                    CostPrice = 95000,
                    StockQuantity = 20,
                    MinStockQuantity = 5,
                    IsActive = true,
                    CategoryId = 13,
                    BrandId = null
                },

                new Product
                {
                    ProductId = 15,
                    Barcode = "8934868000015",
                    ProductName = "Túi rác tự phân hủy 55x65cm",
                    Unit = "Cuộn",
                    Price = 35000,
                    CostPrice = 25000,
                    StockQuantity = 45,
                    MinStockQuantity = 10,
                    IsActive = true,
                    CategoryId = 15,
                    BrandId = null
                }
            );


            // =====================================================
            // 4. CUSTOMER - 15 KHÁCH HÀNG
            // Địa chỉ: có SỐ NHÀ + QUẬN
            // =====================================================
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Nguyễn Văn An",
                    PhoneNumber = "0901122334",
                    Address = "123 Đường Nguyễn Trãi, Q.1",
                    MembershipRank = "Vàng",
                    RewardPoints = 210
                },

                new Customer
                {
                    CustomerId = 2,
                    CustomerName = "Trần Thị Bình",
                    PhoneNumber = "0918877665",
                    Address = "456 Đường Trần Hưng Đạo, Q.5",
                    MembershipRank = "Bạc",
                    RewardPoints = 85
                },

                new Customer
                {
                    CustomerId = 3,
                    CustomerName = "Lê Văn Cường",
                    PhoneNumber = "0983344556",
                    Address = "78 Đường Võ Văn Tần, Q.3",
                    MembershipRank = "Chuẩn",
                    RewardPoints = 25
                },

                new Customer
                {
                    CustomerId = 4,
                    CustomerName = "Phạm Thị Dung",
                    PhoneNumber = "0934567890",
                    Address = "12 Đường Thành Thái, Q.10",
                    MembershipRank = "Kim Cương",
                    RewardPoints = 540
                },

                new Customer
                {
                    CustomerId = 5,
                    CustomerName = "Hoàng Minh Đức",
                    PhoneNumber = "0971122444",
                    Address = "89 Đường Phan Đăng Lưu, Q.Phú Nhuận",
                    MembershipRank = "Bạc",
                    RewardPoints = 110
                },

                new Customer
                {
                    CustomerId = 6,
                    CustomerName = "Đỗ Thu Hà",
                    PhoneNumber = "0909988776",
                    Address = "204 Đường Điện Biên Phủ, Q.3",
                    MembershipRank = "Chuẩn",
                    RewardPoints = 15
                },

                new Customer
                {
                    CustomerId = 7,
                    CustomerName = "Vũ Quốc Hùng",
                    PhoneNumber = "0945112233",
                    Address = "55 Đường Xô Viết Nghệ Tĩnh, Q.Bình Thạnh",
                    MembershipRank = "Vàng",
                    RewardPoints = 320
                },

                new Customer
                {
                    CustomerId = 8,
                    CustomerName = "Đặng Mai Hương",
                    PhoneNumber = "0966778899",
                    Address = "15 Đường Nguyễn Xí, Q.Bình Thạnh",
                    MembershipRank = "Chuẩn",
                    RewardPoints = 0
                },

                new Customer
                {
                    CustomerId = 9,
                    CustomerName = "Bùi Anh Khoa",
                    PhoneNumber = "0931223344",
                    Address = "88 Đường 3 Tháng 2, Q.10",
                    MembershipRank = "Bạc",
                    RewardPoints = 95
                },

                new Customer
                {
                    CustomerId = 10,
                    CustomerName = "Ngô Bích Ngọc",
                    PhoneNumber = "0978990011",
                    Address = "302 Đường Nguyễn Đình Chiểu, Q.3",
                    MembershipRank = "Vàng",
                    RewardPoints = 280
                },

                new Customer
                {
                    CustomerId = 11,
                    CustomerName = "Trịnh Quốc Bảo",
                    PhoneNumber = "0903445566",
                    Address = "12 Đường Lê Thị Hồng Gấm, Q.1",
                    MembershipRank = "Chuẩn",
                    RewardPoints = 40
                },

                new Customer
                {
                    CustomerId = 12,
                    CustomerName = "Lý Mỹ Duyên",
                    PhoneNumber = "0915667788",
                    Address = "74 Đường Lý Thường Kiệt, Q.10",
                    MembershipRank = "Kim Cương",
                    RewardPoints = 610
                },

                new Customer
                {
                    CustomerId = 13,
                    CustomerName = "Đoàn Tấn Phát",
                    PhoneNumber = "0982114455",
                    Address = "450 Đường Điện Biên Phủ, Q.Bình Thạnh",
                    MembershipRank = "Bạc",
                    RewardPoints = 130
                },

                new Customer
                {
                    CustomerId = 14,
                    CustomerName = "Dương Khánh Linh",
                    PhoneNumber = "0947889900",
                    Address = "19 Đường Nguyễn Văn Cừ, Q.5",
                    MembershipRank = "Chuẩn",
                    RewardPoints = 10
                },

                new Customer
                {
                    CustomerId = 15,
                    CustomerName = "Phan Hoài Nam",
                    PhoneNumber = "0963221100",
                    Address = "500 Đường Cộng Hòa, Q.Tân Bình",
                    MembershipRank = "Vàng",
                    RewardPoints = 190
                }
            );
        }
    }
}