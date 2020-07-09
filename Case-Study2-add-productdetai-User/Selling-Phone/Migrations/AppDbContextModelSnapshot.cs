﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Selling_Phone.Models;

namespace Selling_Phone.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Selling_Phone.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Selling_Phone.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Apple"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Samsung"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "XiaoMi"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Oppo"
                        });
                });

            modelBuilder.Entity("Selling_Phone.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalProduct")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            OrderDate = new DateTime(2020, 7, 9, 9, 19, 39, 559, DateTimeKind.Local).AddTicks(289),
                            ShipAddress = "28 NTP",
                            ShipName = "Hiệp",
                            Status = 0,
                            TotalPrice = 62580000m,
                            TotalProduct = 2
                        });
                });

            modelBuilder.Entity("Selling_Phone.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            ProductId = 1,
                            Price = 31290000m,
                            Quantity = 2
                        },
                        new
                        {
                            OrderId = 1,
                            ProductId = 2,
                            Price = 31290000m,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("Selling_Phone.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarPatch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatteryCapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FrontCamera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Graphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HardDrive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<decimal>("OldPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OperatingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Promotion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RearCamera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Screen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AvatarPatch = "images/iphone-11-pro-max.png",
                            BatteryCapacity = "3969 mAh, có sạc nhanh",
                            CategoryId = 1,
                            FrontCamera = "12 Mp",
                            HardDrive = "256 GB",
                            Memory = "4 GB ",
                            Name = "Apple iPhone 11 Pro Max-512GB",
                            OldPrice = 0m,
                            OperatingSystem = "Ios 13",
                            Price = 36790000m,
                            Processor = "Apple A13 Bionic",
                            ProductDescription = "Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.",
                            RearCamera = "3camera 12 Mp",
                            Screen = "OLED, 6.5, Super Retina XDR",
                            Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G"
                        },
                        new
                        {
                            ProductId = 2,
                            AvatarPatch = "images/iphone-11-pro.png",
                            BatteryCapacity = "3120 mAh, có sạc nhanh",
                            CategoryId = 1,
                            FrontCamera = "12 Mp",
                            HardDrive = "256 GB",
                            Memory = "4 GB ",
                            Name = "Apple iPhone 11 Pro-256GB",
                            OldPrice = 0m,
                            OperatingSystem = "Ios 13",
                            Price = 31290000m,
                            Processor = "Apple A13 Bionic",
                            ProductDescription = "Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.",
                            RearCamera = "3camera 12 Mp",
                            Screen = "OLED, 5.8, Super Retina XDR",
                            Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G"
                        },
                        new
                        {
                            ProductId = 3,
                            AvatarPatch = "images/note-10-p.png",
                            BatteryCapacity = "4300 mAh, có sạc nhanh",
                            CategoryId = 2,
                            FrontCamera = "12 Mp",
                            HardDrive = "256 GB",
                            Memory = "12 GB ",
                            Name = "Samsung Galaxy Note 10 Plus",
                            OldPrice = 0m,
                            OperatingSystem = "Android 10",
                            Price = 18000000m,
                            Processor = "SnapDragon 855",
                            ProductDescription = "Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.",
                            RearCamera = "3 camera 12 Mp",
                            Screen = "OLED, 6.7, ",
                            Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G"
                        },
                        new
                        {
                            ProductId = 4,
                            AvatarPatch = "images/s20Ultra.png",
                            BatteryCapacity = "5000 mAh, có sạc nhanh",
                            CategoryId = 2,
                            FrontCamera = "12 Mp",
                            HardDrive = "256 GB",
                            Memory = "12 GB ",
                            Name = "Samsung Galaxy S20 Ultra ",
                            OldPrice = 0m,
                            OperatingSystem = "Android 10",
                            Price = 20990000m,
                            Processor = "SnapDragon 865",
                            ProductDescription = "Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.",
                            RearCamera = "3 camera 12 Mp",
                            Screen = "OLED, 6.7,",
                            Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G"
                        },
                        new
                        {
                            ProductId = 5,
                            AvatarPatch = "images/iphone-11-pro-max.png",
                            BatteryCapacity = "3969 mAh, có sạc nhanh",
                            CategoryId = 1,
                            FrontCamera = "12 Mp",
                            HardDrive = "256 GB",
                            Memory = "4 GB ",
                            Name = "Apple iPhone 11 Pro Max-512GB",
                            OldPrice = 0m,
                            OperatingSystem = "Ios 13",
                            Price = 36790000m,
                            Processor = "Apple A13 Bionic",
                            ProductDescription = "Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.",
                            RearCamera = "3camera 12 Mp",
                            Screen = "OLED, 6.5, Super Retina XDR",
                            Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G"
                        },
                        new
                        {
                            ProductId = 6,
                            AvatarPatch = "images/iphone-11-pro.png",
                            BatteryCapacity = "3120 mAh, có sạc nhanh",
                            CategoryId = 1,
                            FrontCamera = "12 Mp",
                            HardDrive = "256 GB",
                            Memory = "4 GB ",
                            Name = "Apple iPhone 11 Pro-256GB",
                            OldPrice = 0m,
                            OperatingSystem = "Ios 13",
                            Price = 31290000m,
                            Processor = "Apple A13 Bionic",
                            ProductDescription = "Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.",
                            RearCamera = "3camera 12 Mp",
                            Screen = "OLED, 5.8, Super Retina XDR",
                            Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G"
                        },
                        new
                        {
                            ProductId = 7,
                            AvatarPatch = "images/note-10-p.png",
                            BatteryCapacity = "4300 mAh, có sạc nhanh",
                            CategoryId = 2,
                            FrontCamera = "12 Mp",
                            HardDrive = "256 GB",
                            Memory = "12 GB ",
                            Name = "Samsung Galaxy Note 10 Plus",
                            OldPrice = 0m,
                            OperatingSystem = "Android 10",
                            Price = 18000000m,
                            Processor = "SnapDragon 855",
                            ProductDescription = "Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.",
                            RearCamera = "3 camera 12 Mp",
                            Screen = "OLED, 6.7, ",
                            Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G"
                        },
                        new
                        {
                            ProductId = 8,
                            AvatarPatch = "images/s20Ultra.png",
                            BatteryCapacity = "5000 mAh, có sạc nhanh",
                            CategoryId = 2,
                            FrontCamera = "12 Mp",
                            HardDrive = "256 GB",
                            Memory = "12 GB ",
                            Name = "Samsung Galaxy S20 Ultra ",
                            OldPrice = 0m,
                            OperatingSystem = "Android 10",
                            Price = 20990000m,
                            Processor = "SnapDragon 865",
                            ProductDescription = "Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.",
                            RearCamera = "3 camera 12 Mp",
                            Screen = "OLED, 6.7,",
                            Sim = "1 eSIM & 1 Nano SIM, Hỗ trợ 4G"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Selling_Phone.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Selling_Phone.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Selling_Phone.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Selling_Phone.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Selling_Phone.Models.OrderDetail", b =>
                {
                    b.HasOne("Selling_Phone.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Selling_Phone.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Selling_Phone.Models.Product", b =>
                {
                    b.HasOne("Selling_Phone.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
