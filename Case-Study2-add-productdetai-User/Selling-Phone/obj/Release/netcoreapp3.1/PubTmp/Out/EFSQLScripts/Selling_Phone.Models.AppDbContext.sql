IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629022156_InitDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200629022156_InitDb', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629022511_CreateProductTable')
BEGIN
    CREATE TABLE [Products] (
        [ProductId] int NOT NULL IDENTITY,
        [Name] nvarchar(60) NOT NULL,
        [Price] nvarchar(max) NOT NULL,
        [AvatarPatch] nvarchar(max) NULL,
        [Manufactory] int NOT NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([ProductId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629022511_CreateProductTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200629022511_CreateProductTable', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629025325_SeedingProductData')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'AvatarPatch', N'Manufactory', N'Name', N'Price') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    INSERT INTO [Products] ([ProductId], [AvatarPatch], [Manufactory], [Name], [Price])
    VALUES (1, N'images/iphone-11-pro-max.png', 0, N'Apple iPhone 11 Pro Max-512GB', N'36.790.000 đ'),
    (2, N'images/iphone-11-pro.png', 0, N'Apple iPhone 11 Pro-256GB', N'30.490.000 đ'),
    (3, N'images/note-10-p.png', 0, N'Samsung Galaxy Note 10 Plus', N'23.890.000 đ'),
    (4, N'images/s20Ultra.png', 0, N'Samsung Galaxy S20 Ultra ', N'20.950.000 đ');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'AvatarPatch', N'Manufactory', N'Name', N'Price') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629025325_SeedingProductData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200629025325_SeedingProductData', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629065147_InitIdentityTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200629065147_InitIdentityTable', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629092234_ExtendAspNetUserTable')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [Address] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629092234_ExtendAspNetUserTable')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [City] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629092234_ExtendAspNetUserTable')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [Gender] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200629092234_ExtendAspNetUserTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200629092234_ExtendAspNetUserTable', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [BatteryCapacity] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [FrontCamera] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [Graphics] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [HardDrive] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [Memory] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [OperatingSystem] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [Processor] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [RearCamera] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [Screen] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    ALTER TABLE [Products] ADD [Sim] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630040021_InitColumProduct')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200630040021_InitColumProduct', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630041344_AddAndSeddingDataColumnProductDescription')
BEGIN
    ALTER TABLE [Products] ADD [ProductDescription] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630041344_AddAndSeddingDataColumnProductDescription')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200630041344_AddAndSeddingDataColumnProductDescription', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630041852_SeedingDataColumnProducDescription')
BEGIN
    UPDATE [Products] SET [BatteryCapacity] = N'3969 mAh, có sạc nhanh', [FrontCamera] = N'12 Mp', [HardDrive] = N'256 GB', [Memory] = N'4 GB ', [OperatingSystem] = N'Ios 13', [Processor] = N'Apple A13 Bionic', [ProductDescription] = N'Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.', [RearCamera] = N'3camera 12 Mp', [Screen] = N'OLED, 6.5, Super Retina XDR', [Sim] = N'1 eSIM & 1 Nano SIM, Hỗ trợ 4G'
    WHERE [ProductId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630041852_SeedingDataColumnProducDescription')
BEGIN
    UPDATE [Products] SET [BatteryCapacity] = N'3120 mAh, có sạc nhanh', [FrontCamera] = N'12 Mp', [HardDrive] = N'256 GB', [Memory] = N'4 GB ', [OperatingSystem] = N'Ios 13', [Processor] = N'Apple A13 Bionic', [ProductDescription] = N'Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.', [RearCamera] = N'3camera 12 Mp', [Screen] = N'OLED, 5.8, Super Retina XDR', [Sim] = N'1 eSIM & 1 Nano SIM, Hỗ trợ 4G'
    WHERE [ProductId] = 2;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630041852_SeedingDataColumnProducDescription')
BEGIN
    UPDATE [Products] SET [BatteryCapacity] = N'4300 mAh, có sạc nhanh', [FrontCamera] = N'12 Mp', [HardDrive] = N'256 GB', [Memory] = N'12 GB ', [OperatingSystem] = N'Android 10', [Processor] = N'SnapDragon 855', [ProductDescription] = N'Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.', [RearCamera] = N'3 camera 12 Mp', [Screen] = N'OLED, 6.7, ', [Sim] = N'1 eSIM & 1 Nano SIM, Hỗ trợ 4G'
    WHERE [ProductId] = 3;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630041852_SeedingDataColumnProducDescription')
BEGIN
    UPDATE [Products] SET [BatteryCapacity] = N'5000 mAh, có sạc nhanh', [FrontCamera] = N'12 Mp', [HardDrive] = N'256 GB', [Memory] = N'12 GB ', [OperatingSystem] = N'Android 10', [Processor] = N'SnapDragon 865', [ProductDescription] = N'Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.', [RearCamera] = N'3 camera 12 Mp', [Screen] = N'OLED, 6.7,', [Sim] = N'1 eSIM & 1 Nano SIM, Hỗ trợ 4G'
    WHERE [ProductId] = 4;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630041852_SeedingDataColumnProducDescription')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'AvatarPatch', N'BatteryCapacity', N'FrontCamera', N'Graphics', N'HardDrive', N'Manufactory', N'Memory', N'Name', N'OperatingSystem', N'Price', N'Processor', N'ProductDescription', N'RearCamera', N'Screen', N'Sim') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    INSERT INTO [Products] ([ProductId], [AvatarPatch], [BatteryCapacity], [FrontCamera], [Graphics], [HardDrive], [Manufactory], [Memory], [Name], [OperatingSystem], [Price], [Processor], [ProductDescription], [RearCamera], [Screen], [Sim])
    VALUES (5, N'images/iphone-11-pro-max.png', N'3969 mAh, có sạc nhanh', N'12 Mp', NULL, N'256 GB', 0, N'4 GB ', N'Apple iPhone 11 Pro Max-512GB', N'Ios 13', N'36.790.000 đ', N'Apple A13 Bionic', N'Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.', N'3camera 12 Mp', N'OLED, 6.5, Super Retina XDR', N'1 eSIM & 1 Nano SIM, Hỗ trợ 4G'),
    (6, N'images/iphone-11-pro.png', N'3120 mAh, có sạc nhanh', N'12 Mp', NULL, N'256 GB', 0, N'4 GB ', N'Apple iPhone 11 Pro-256GB', N'Ios 13', N'30.490.000 đ', N'Apple A13 Bionic', N'Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.', N'3camera 12 Mp', N'OLED, 5.8, Super Retina XDR', N'1 eSIM & 1 Nano SIM, Hỗ trợ 4G'),
    (7, N'images/note-10-p.png', N'4300 mAh, có sạc nhanh', N'12 Mp', NULL, N'256 GB', 0, N'12 GB ', N'Samsung Galaxy Note 10 Plus', N'Android 10', N'23.890.000 đ', N'SnapDragon 855', N'Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.', N'3 camera 12 Mp', N'OLED, 6.7, ', N'1 eSIM & 1 Nano SIM, Hỗ trợ 4G'),
    (8, N'images/s20Ultra.png', N'5000 mAh, có sạc nhanh', N'12 Mp', NULL, N'256 GB', 0, N'12 GB ', N'Samsung Galaxy S20 Ultra ', N'Android 10', N'20.950.000 đ', N'SnapDragon 865', N'Camera trước nâng cấpCamera trước bộ 3 iPhone 11 được Apple nâng cấp độ phân giải lên đến 12MP, TrueDepth. Đem đến cho người dùng những bức ảnh chụp chân dung với màu sắc đẹp. Ngoài ra, máy còn có khả năng quay video 4K ở tốc độ 60fps và quay video chậm 120fps. Đặc biệt hơn, camera máy sẽ tự động thu nhỏ khi người dùng xoay ngang để chụp được ảnh nhóm.Camera chính tự động lấy nét như smartphone SamsungApple trước đây chỉ sử dụng 10 - 15% cảm biến Focus Pixels để chụp ảnh chứ không dùng như Samsung. Vì thế mà camera Samsung có thể tự động lấy nét chụp ảnh tốt hơn nhiều. Tuy nhiên, giờ đây camera iPhone 2019 đã tích hợp 100% là cảm biển Focus Pixels.Camera zoom trang bị ống kính mới:Camera bộ 3 iPhone đã được nâng cấp lên với một ống kinh góc siêu rộng. Ống kính này có độ phân giải 12MP, góc 120độ, khẩu độ f2.0. Ống kính này giúp thu lại nhiều ánh sáng hơn, có khi lên đến 40% ánh sáng khi chụp ảnh xoá phông. Như vậy, máy giúp người dùng ghi lại tốt nhất những hình ảnh chụp trong môi trường thiếu sáng.Những tính năng công nghệ này là điểm nhấn giúp iPhone 11, 11 Pro và 11 Pro Max, chinh phục được khách hàng. Nếu muốn sở hữu ngay 1 trong bộ 3 sản phẩm hãy đặt hàng ngay tại Di Động Việt để rinh quà lên đến 5 triệu.', N'3 camera 12 Mp', N'OLED, 6.7,', N'1 eSIM & 1 Nano SIM, Hỗ trợ 4G');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'AvatarPatch', N'BatteryCapacity', N'FrontCamera', N'Graphics', N'HardDrive', N'Manufactory', N'Memory', N'Name', N'OperatingSystem', N'Price', N'Processor', N'ProductDescription', N'RearCamera', N'Screen', N'Sim') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630041852_SeedingDataColumnProducDescription')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200630041852_SeedingDataColumnProducDescription', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630045328_UpdateDataPrice')
BEGIN
    UPDATE [Products] SET [Price] = N'36790000'
    WHERE [ProductId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630045328_UpdateDataPrice')
BEGIN
    UPDATE [Products] SET [Price] = N'31290000'
    WHERE [ProductId] = 2;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630045328_UpdateDataPrice')
BEGIN
    UPDATE [Products] SET [Price] = N'18000000'
    WHERE [ProductId] = 3;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630045328_UpdateDataPrice')
BEGIN
    UPDATE [Products] SET [Price] = N'20990000'
    WHERE [ProductId] = 4;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630045328_UpdateDataPrice')
BEGIN
    UPDATE [Products] SET [Price] = N'36790000'
    WHERE [ProductId] = 5;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630045328_UpdateDataPrice')
BEGIN
    UPDATE [Products] SET [Price] = N'31290000'
    WHERE [ProductId] = 6;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630045328_UpdateDataPrice')
BEGIN
    UPDATE [Products] SET [Price] = N'18000000'
    WHERE [ProductId] = 7;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630045328_UpdateDataPrice')
BEGIN
    UPDATE [Products] SET [Price] = N'20990000'
    WHERE [ProductId] = 8;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200630045328_UpdateDataPrice')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200630045328_UpdateDataPrice', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702132756_ChangeDatabase')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200702132756_ChangeDatabase', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'Price');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Products] ALTER COLUMN [Price] decimal(18,2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    UPDATE [Products] SET [Price] = 36790000.0
    WHERE [ProductId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    UPDATE [Products] SET [Price] = 31290000.0
    WHERE [ProductId] = 2;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    UPDATE [Products] SET [Price] = 18000000.0
    WHERE [ProductId] = 3;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    UPDATE [Products] SET [Price] = 20990000.0
    WHERE [ProductId] = 4;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    UPDATE [Products] SET [Price] = 36790000.0
    WHERE [ProductId] = 5;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    UPDATE [Products] SET [Price] = 31290000.0
    WHERE [ProductId] = 6;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    UPDATE [Products] SET [Price] = 18000000.0
    WHERE [ProductId] = 7;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    UPDATE [Products] SET [Price] = 20990000.0
    WHERE [ProductId] = 8;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200702134333_changDecimalPrice')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200702134333_changDecimalPrice', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    ALTER TABLE [Products] ADD [CategoryId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    CREATE TABLE [Categories] (
        [CategoryId] int NOT NULL IDENTITY,
        [CategoryName] nvarchar(100) NOT NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([CategoryId], [CategoryName])
    VALUES (1, N'Apple'),
    (2, N'Samsung'),
    (3, N'XiaoMi'),
    (4, N'Oppo');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    UPDATE [Products] SET [CategoryId] = 1
    WHERE [ProductId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    UPDATE [Products] SET [CategoryId] = 1
    WHERE [ProductId] = 2;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    UPDATE [Products] SET [CategoryId] = 2
    WHERE [ProductId] = 3;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    UPDATE [Products] SET [CategoryId] = 2
    WHERE [ProductId] = 4;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    UPDATE [Products] SET [CategoryId] = 1
    WHERE [ProductId] = 5;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    UPDATE [Products] SET [CategoryId] = 1
    WHERE [ProductId] = 6;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    UPDATE [Products] SET [CategoryId] = 2
    WHERE [ProductId] = 7;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    UPDATE [Products] SET [CategoryId] = 2
    WHERE [ProductId] = 8;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    ALTER TABLE [Products] ADD CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703044040_CreateCatogeryTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200703044040_CreateCatogeryTable', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703074010_CreateOrderDetailTable')
BEGIN
    CREATE TABLE [Orders] (
        [OrderId] int NOT NULL IDENTITY,
        [OrderDate] datetime2 NOT NULL,
        [ShipName] nvarchar(max) NULL,
        [ShipAddress] nvarchar(max) NULL,
        [TotalProduct] int NOT NULL,
        [TotalPrice] decimal(18,2) NOT NULL,
        [ShipPhoneNumber] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703074010_CreateOrderDetailTable')
BEGIN
    CREATE TABLE [OrderDetails] (
        [OrderId] int NOT NULL,
        [ProductId] int NOT NULL,
        [Quantity] int NOT NULL,
        [Price] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([OrderId], [ProductId]),
        CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([OrderId]) ON DELETE CASCADE,
        CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703074010_CreateOrderDetailTable')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderId', N'OrderDate', N'ShipAddress', N'ShipName', N'ShipPhoneNumber', N'Status', N'TotalPrice', N'TotalProduct') AND [object_id] = OBJECT_ID(N'[Orders]'))
        SET IDENTITY_INSERT [Orders] ON;
    INSERT INTO [Orders] ([OrderId], [OrderDate], [ShipAddress], [ShipName], [ShipPhoneNumber], [Status], [TotalPrice], [TotalProduct])
    VALUES (1, '2020-07-03T14:40:09.5863577+07:00', N'28 NTP', N'Hiệp', NULL, 0, 62580000.0, 2);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderId', N'OrderDate', N'ShipAddress', N'ShipName', N'ShipPhoneNumber', N'Status', N'TotalPrice', N'TotalProduct') AND [object_id] = OBJECT_ID(N'[Orders]'))
        SET IDENTITY_INSERT [Orders] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703074010_CreateOrderDetailTable')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderId', N'ProductId', N'Price', N'Quantity') AND [object_id] = OBJECT_ID(N'[OrderDetails]'))
        SET IDENTITY_INSERT [OrderDetails] ON;
    INSERT INTO [OrderDetails] ([OrderId], [ProductId], [Price], [Quantity])
    VALUES (1, 1, 31290000.0, 2);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderId', N'ProductId', N'Price', N'Quantity') AND [object_id] = OBJECT_ID(N'[OrderDetails]'))
        SET IDENTITY_INSERT [OrderDetails] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703074010_CreateOrderDetailTable')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderId', N'ProductId', N'Price', N'Quantity') AND [object_id] = OBJECT_ID(N'[OrderDetails]'))
        SET IDENTITY_INSERT [OrderDetails] ON;
    INSERT INTO [OrderDetails] ([OrderId], [ProductId], [Price], [Quantity])
    VALUES (1, 2, 31290000.0, 2);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderId', N'ProductId', N'Price', N'Quantity') AND [object_id] = OBJECT_ID(N'[OrderDetails]'))
        SET IDENTITY_INSERT [OrderDetails] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703074010_CreateOrderDetailTable')
BEGIN
    CREATE INDEX [IX_OrderDetails_ProductId] ON [OrderDetails] ([ProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703074010_CreateOrderDetailTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200703074010_CreateOrderDetailTable', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200705041949_deletecolumnManufactory')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'Manufactory');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Products] DROP COLUMN [Manufactory];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200705041949_deletecolumnManufactory')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'Processor');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Products] ALTER COLUMN [Processor] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200705041949_deletecolumnManufactory')
BEGIN
    UPDATE [Orders] SET [OrderDate] = '2020-07-05T11:19:48.4115708+07:00'
    WHERE [OrderId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200705041949_deletecolumnManufactory')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200705041949_deletecolumnManufactory', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200706092658_updateViewHOmemodel')
BEGIN
    UPDATE [Orders] SET [OrderDate] = '2020-07-06T16:26:57.7460028+07:00'
    WHERE [OrderId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200706092658_updateViewHOmemodel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200706092658_updateViewHOmemodel', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200708014743_AddDOBcolumn')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [DOB] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200708014743_AddDOBcolumn')
BEGIN
    UPDATE [Orders] SET [OrderDate] = '2020-07-08T08:47:42.7190118+07:00'
    WHERE [OrderId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200708014743_AddDOBcolumn')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200708014743_AddDOBcolumn', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200708015431_updateDOBcolumn')
BEGIN
    UPDATE [Orders] SET [OrderDate] = '2020-07-08T08:54:30.5270184+07:00'
    WHERE [OrderId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200708015431_updateDOBcolumn')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200708015431_updateDOBcolumn', N'3.1.5');
END;

GO

