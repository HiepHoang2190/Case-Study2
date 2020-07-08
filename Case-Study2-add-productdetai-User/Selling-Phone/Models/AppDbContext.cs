using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderId, od.ProductId });
            
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {   
                    AvatarPatch = "images/iphone-11-pro-max.png",
                    ProductId = 1,
                    Name = "Apple iPhone 11 Pro Max-512GB",
                    Price = 36790000,
                    CategoryId=1,
                    
                    Processor = "Apple A13 Bionic",
                    Memory = "4 GB ",
                    Screen = "OLED, 6.5, Super Retina XDR",
                    OperatingSystem = "Ios 13",
                    RearCamera = "3camera 12 Mp",
                    FrontCamera = "12 Mp",
                    HardDrive = "256 GB",
                    Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
                    BatteryCapacity = "3969 mAh, có sạc nhanh",
                    ProductDescription = "Camera trước nâng cấp" +
                    "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
                    "Camera chính tự động lấy nét như smartphone Samsung" +
                    "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
                    "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
                    "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."

                },
                  new Product()
                  {
                      CategoryId = 1,
                      AvatarPatch = "images/iphone-11-pro.png",
                      ProductId = 2,
                      Name = "Apple iPhone 11 Pro-256GB",
                      Price = 31290000,
                      
                      Processor = "Apple A13 Bionic",
                      Memory = "4 GB ",
                      Screen = "OLED, 5.8, Super Retina XDR",
                      OperatingSystem = "Ios 13",
                      RearCamera = "3camera 12 Mp",
                      FrontCamera = "12 Mp",
                      HardDrive = "256 GB",
                      Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
                      BatteryCapacity = "3120 mAh, có sạc nhanh",
                      ProductDescription = "Camera trước nâng cấp" +
                    "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
                    "Camera chính tự động lấy nét như smartphone Samsung" +
                    "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
                    "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
                    "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
                  },
                    new Product()
                    {
                        CategoryId = 2,
                        AvatarPatch = "images/note-10-p.png",
                        ProductId = 3,
                        Name = "Samsung Galaxy Note 10 Plus",
                        Price = 18000000,
                        
                        Processor = "SnapDragon 855",
                        Memory = "12 GB ",
                        Screen = "OLED, 6.7, ",
                        OperatingSystem = "Android 10",
                        RearCamera = "3 camera 12 Mp",
                        FrontCamera = "12 Mp",
                        HardDrive = "256 GB",
                        Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
                        BatteryCapacity = "4300 mAh, có sạc nhanh",
                        ProductDescription = "Camera trước nâng cấp" +
                    "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
                    "Camera chính tự động lấy nét như smartphone Samsung" +
                    "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
                    "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
                    "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
                    },
                      new Product()
                      {
                          CategoryId = 2,
                          AvatarPatch = "images/s20Ultra.png",
                          ProductId = 4,
                          Name = "Samsung Galaxy S20 Ultra ",
                          Price = 20990000,
                          
                          Processor = "SnapDragon 865",
                          Memory = "12 GB ",
                          Screen = "OLED, 6.7,",
                          OperatingSystem = "Android 10",
                          RearCamera = "3 camera 12 Mp",
                          FrontCamera = "12 Mp",
                          HardDrive = "256 GB",
                          Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
                          BatteryCapacity = "5000 mAh, có sạc nhanh",
                          ProductDescription = "Camera trước nâng cấp" +
                    "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
                    "Camera chính tự động lấy nét như smartphone Samsung" +
                    "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
                    "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
                    "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
                      },
                        new Product()
                        {
                            CategoryId = 1,
                            AvatarPatch = "images/iphone-11-pro-max.png",
                            ProductId = 5,
                            Name = "Apple iPhone 11 Pro Max-512GB",
                            Price = 36790000,
                            
                            Processor = "Apple A13 Bionic",
                            Memory = "4 GB ",
                            Screen = "OLED, 6.5, Super Retina XDR",
                            OperatingSystem = "Ios 13",
                            RearCamera = "3camera 12 Mp",
                            FrontCamera = "12 Mp",
                            HardDrive = "256 GB",
                            Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
                            BatteryCapacity = "3969 mAh, có sạc nhanh",
                            ProductDescription = "Camera trước nâng cấp" +
                    "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
                    "Camera chính tự động lấy nét như smartphone Samsung" +
                    "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
                    "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
                    "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
                        },
                  new Product()
                  {
                      CategoryId = 1,
                      AvatarPatch = "images/iphone-11-pro.png",
                      ProductId = 6,
                      Name = "Apple iPhone 11 Pro-256GB",
                      Price = 31290000,
                    
                      Processor = "Apple A13 Bionic",
                      Memory = "4 GB ",
                      Screen = "OLED, 5.8, Super Retina XDR",
                      OperatingSystem = "Ios 13",
                      RearCamera = "3camera 12 Mp",
                      FrontCamera = "12 Mp",
                      HardDrive = "256 GB",
                      Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
                      BatteryCapacity = "3120 mAh, có sạc nhanh",
                      ProductDescription = "Camera trước nâng cấp" +
                    "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
                    "Camera chính tự động lấy nét như smartphone Samsung" +
                    "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
                    "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
                    "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
                  },
                    new Product()
                    {

                        CategoryId = 2,
                        AvatarPatch = "images/note-10-p.png",
                        ProductId = 7,
                        Name = "Samsung Galaxy Note 10 Plus",
                        Price = 18000000,
                      
                        Processor = "SnapDragon 855",
                        Memory = "12 GB ",
                        Screen = "OLED, 6.7, ",
                        OperatingSystem = "Android 10",
                        RearCamera = "3 camera 12 Mp",
                        FrontCamera = "12 Mp",
                        HardDrive = "256 GB",
                        Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
                        BatteryCapacity = "4300 mAh, có sạc nhanh",
                        ProductDescription = "Camera trước nâng cấp" +
                    "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
                    "Camera chính tự động lấy nét như smartphone Samsung" +
                    "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
                    "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
                    "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
                    },
                      new Product()
                      {
                          CategoryId = 2,
                          AvatarPatch = "images/s20Ultra.png",
                          ProductId = 8,
                          Name = "Samsung Galaxy S20 Ultra ",
                          Price = 20990000,
                        
                          Processor = "SnapDragon 865",
                          Memory = "12 GB ",
                          Screen = "OLED, 6.7,",
                          OperatingSystem = "Android 10",
                          RearCamera = "3 camera 12 Mp",
                          FrontCamera = "12 Mp",
                          HardDrive = "256 GB",
                          Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
                          BatteryCapacity = "5000 mAh, có sạc nhanh",
                          ProductDescription = "Camera trước nâng cấp" +
                    "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
                    "Camera chính tự động lấy nét như smartphone Samsung" +
                    "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
                    "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
                    "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
                      }
                );
            modelBuilder.Entity<Category>().HasData(
                 new Category()
                 {
                     CategoryId = 1,
                     CategoryName = "Apple"
                 },
                 new Category()
                 {
                     CategoryId = 2,
                     CategoryName = "Samsung"
                 },
                 new Category()
                 {
                     CategoryId = 3,
                     CategoryName = "XiaoMi"
                 },
                  new Category()
                  {
                      CategoryId = 4,
                      CategoryName = "Oppo"
                  }
                );
            modelBuilder.Entity<Order>().HasData(
                  new Order()
                  {
                      OrderDate = DateTime.Now,
                      OrderId = 1,
                      ShipAddress = "28 NTP",
                      ShipName = "Hiệp",
                      Status = OrderStatus.InProgress,
                      TotalProduct = 2,
                      TotalPrice = 62580000
                  }
                );
            modelBuilder.Entity<OrderDetail>().HasData(
                  new OrderDetail()
                  {
                      OrderId=1,
                      ProductId=1,
                      Quantity=2,
                      Price= 31290000
                  },
                  new OrderDetail()
                  {
                      OrderId=1,
                      ProductId = 2,
                      Quantity = 2,
                      Price = 31290000
                  }
                );
        }
    }
}
