using Selling_Phone.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;

        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Edit(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Gets()
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.Get(int id)
        {
            throw new NotImplementedException();
        }
        //public ProductRepository()
        //{
        //    products = new List<Product>()
        //    {
        //        new Product()
        //        {
        //            AvatarPatch="images/iphone-11-pro-max.png",
        //            ProductId=1,
        //            Name="Apple iPhone 11 Pro Max-512GB",
        //            Price="36790000",
        //            Manufactory=Manu.VietNam,
        //            Processor="Apple A13 Bionic",
        //            Memory="4 GB ",
        //            Screen="OLED, 6.5, Super Retina XDR",
        //            OperatingSystem="Ios 13",
        //            RearCamera="3camera 12 Mp",
        //            FrontCamera="12 Mp",
        //            HardDrive="256 GB",
        //            Sim="1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
        //            BatteryCapacity="3969 mAh, có sạc nhanh",
        //            ProductDescription="Camera trước nâng cấp" +
        //            "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
        //            "Camera chính tự động lấy nét như smartphone Samsung" +
        //            "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
        //            "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
        //            "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."

        //        },
        //          new Product()
        //        {
        //            AvatarPatch="images/iphone-11-pro.png",
        //            ProductId=2,
        //            Name="Apple iPhone 11 Pro-256GB",
        //            Price="30490000",
        //            Manufactory=Manu.VietNam,
        //             Processor="Apple A13 Bionic",
        //            Memory="4 GB ",
        //            Screen="OLED, 5.8, Super Retina XDR",
        //            OperatingSystem="Ios 13",
        //            RearCamera="3camera 12 Mp",
        //            FrontCamera="12 Mp",
        //            HardDrive="256 GB",
        //            Sim="1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
        //            BatteryCapacity="3120 mAh, có sạc nhanh",
        //            ProductDescription="Camera trước nâng cấp" +
        //            "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
        //            "Camera chính tự động lấy nét như smartphone Samsung" +
        //            "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
        //            "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
        //            "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
        //        },
        //            new Product()
        //        {
        //            AvatarPatch="images/note-10-p.png",
        //            ProductId=3,
        //            Name="Samsung Galaxy Note 10 Plus",
        //            Price="23890000",
        //            Manufactory=Manu.VietNam, 
        //            Processor="SnapDragon 855",
        //            Memory="12 GB ",
        //            Screen="OLED, 6.7, ",
        //            OperatingSystem="Android 10",
        //            RearCamera="3 camera 12 Mp",
        //            FrontCamera="12 Mp",
        //            HardDrive="256 GB",
        //            Sim="1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
        //            BatteryCapacity="4300 mAh, có sạc nhanh",
        //            ProductDescription="Camera trước nâng cấp" +
        //            "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
        //            "Camera chính tự động lấy nét như smartphone Samsung" +
        //            "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
        //            "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
        //            "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
        //        },
        //              new Product()
        //        {
        //            AvatarPatch="images/s20Ultra.png",
        //            ProductId=4,
        //            Name="Samsung Galaxy S20 Ultra ",
        //            Price="20950000",
        //            Manufactory=Manu.VietNam,
        //            Processor="SnapDragon 865",
        //            Memory="12 GB ",
        //            Screen="OLED, 6.7,",
        //            OperatingSystem="Android 10",
        //            RearCamera="3 camera 12 Mp",
        //            FrontCamera="12 Mp",
        //            HardDrive="256 GB",
        //            Sim="1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
        //            BatteryCapacity="5000 mAh, có sạc nhanh",
        //            ProductDescription="Camera trước nâng cấp" +
        //            "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
        //            "Camera chính tự động lấy nét như smartphone Samsung" +
        //            "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
        //            "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
        //            "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
        //        },
        //                new Product()
        //        {
        //            AvatarPatch="images/iphone-11-pro-max.png",
        //            ProductId=5,
        //            Name="Apple iPhone 11 Pro Max-512GB",
        //            Price="36790000",
        //            Manufactory=Manu.VietNam,
        //            Processor="Apple A13 Bionic",
        //            Memory="4 GB ",
        //            Screen="OLED, 6.5, Super Retina XDR",
        //            OperatingSystem="Ios 13",
        //            RearCamera="3camera 12 Mp",
        //            FrontCamera="12 Mp",
        //            HardDrive="256 GB",
        //            Sim="1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
        //            BatteryCapacity="3969 mAh, có sạc nhanh",
        //            ProductDescription="Camera trước nâng cấp" +
        //            "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
        //            "Camera chính tự động lấy nét như smartphone Samsung" +
        //            "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
        //            "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
        //            "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
        //        },
        //          new Product()
        //        {
        //            AvatarPatch="images/iphone-11-pro.png",
        //            ProductId=6,
        //            Name="Apple iPhone 11 Pro-256GB",
        //            Price="30490000",
        //            Manufactory=Manu.VietNam,
        //            Processor="Apple A13 Bionic",
        //            Memory="4 GB ",
        //            Screen="OLED, 5.8, Super Retina XDR",
        //            OperatingSystem="Ios 13",
        //            RearCamera="3camera 12 Mp",
        //            FrontCamera="12 Mp",
        //            HardDrive="256 GB",
        //            Sim="1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
        //            BatteryCapacity="3120 mAh, có sạc nhanh",
        //            ProductDescription="Camera trước nâng cấp" +
        //            "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
        //            "Camera chính tự động lấy nét như smartphone Samsung" +
        //            "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
        //            "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
        //            "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
        //        },
        //            new Product()
        //        {
        //            AvatarPatch="images/note-10-p.png",
        //            ProductId=7,
        //            Name="Samsung Galaxy Note 10 Plus",
        //            Price="23890000",
        //            Manufactory=Manu.VietNam,
        //            Processor="SnapDragon 855",
        //            Memory="12 GB ",
        //            Screen="OLED, 6.7, ",
        //            OperatingSystem="Android 10",
        //            RearCamera="3 camera 12 Mp",
        //            FrontCamera="12 Mp",
        //            HardDrive="256 GB",
        //            Sim="1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
        //            BatteryCapacity="4300 mAh, có sạc nhanh",
        //            ProductDescription="Camera trước nâng cấp" +
        //            "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
        //            "Camera chính tự động lấy nét như smartphone Samsung" +
        //            "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
        //            "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
        //            "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
        //        },
        //              new Product()
        //        {
        //            AvatarPatch="images/s20Ultra.png",
        //            ProductId=8,
        //            Name="Samsung Galaxy S20 Ultra ",
        //            Price="20950000",
        //            Manufactory=Manu.VietNam,
        //            Processor="SnapDragon 865",
        //            Memory="12 GB ",
        //            Screen="OLED, 6.7,",
        //            OperatingSystem="Android 10",
        //            RearCamera="3 camera 12 Mp",
        //            FrontCamera="12 Mp",
        //            HardDrive="256 GB",
        //            Sim="1 eSIM & 1 Nano SIM, Hỗ trợ 4G",
        //            BatteryCapacity="5000 mAh, có sạc nhanh",
        //            ProductDescription="Camera trước nâng cấp" +
        //            "Camera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm." +
        //            "Camera chính tự động lấy nét như smartphone Samsung" +
        //            "Apple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels." +
        //            "Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng." +
        //            "Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu."
        //        }
        //    };
        //}
        //public Product Create(Product product)
        //{
        //    product.AvatarPatch = "images/iphone-11-pro-max.png";
        //    product.ProductId = products.Max(p => p.ProductId) + 1;
        //    products.Add(product);
        //    return product;
        //}

        //public bool Delete(int id)
        //{
        //    var delPro = Get(id);
        //    if (delPro != null)
        //    {
        //        products.Remove(delPro);
        //        return true;
        //    }
        //    return false;
        //}

        //public Product Edit(Product product)
        //{
        //    var editPro = Get(product.ProductId);
        //    editPro.Name = product.Name;
        //    editPro.Price = product.Price;
        //    editPro.Manufactory = product.Manufactory;
        //    return editPro;
        //}

        //public Product Get(int id)
        //{
        //    return products.FirstOrDefault(p => p.ProductId == id);
        //}

        //public IEnumerable<Product> Gets()
        //{
        //    return products;
        //}
    }
}
