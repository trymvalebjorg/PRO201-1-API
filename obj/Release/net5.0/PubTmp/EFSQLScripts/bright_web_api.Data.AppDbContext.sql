IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [Product] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Image] nvarchar(max) NULL,
        CONSTRAINT [PK_Product] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [RepairedPart] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Image] nvarchar(max) NULL,
        CONSTRAINT [PK_RepairedPart] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [Repairs] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Image] nvarchar(max) NULL,
        [Difficulty] int NOT NULL,
        [Time] int NOT NULL,
        [Pdf] nvarchar(max) NULL,
        CONSTRAINT [PK_Repairs] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [ReplacedPart] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Image] nvarchar(max) NULL,
        CONSTRAINT [PK_ReplacedPart] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [Tools] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Image] nvarchar(max) NULL,
        CONSTRAINT [PK_Tools] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [Report] (
        [Id] int NOT NULL IDENTITY,
        [UserId] int NOT NULL,
        [ProductId] int NOT NULL,
        CONSTRAINT [PK_Report] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Report_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [Steps] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Image] nvarchar(max) NULL,
        [Video] nvarchar(max) NULL,
        [RepairId] int NOT NULL,
        CONSTRAINT [PK_Steps] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Steps_Repairs_RepairId] FOREIGN KEY ([RepairId]) REFERENCES [Repairs] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [Repairs_Tools] (
        [Id] int NOT NULL IDENTITY,
        [RepairId] int NOT NULL,
        [ToolId] int NOT NULL,
        CONSTRAINT [PK_Repairs_Tools] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Repairs_Tools_Repairs_RepairId] FOREIGN KEY ([RepairId]) REFERENCES [Repairs] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Repairs_Tools_Tools_ToolId] FOREIGN KEY ([ToolId]) REFERENCES [Tools] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [Report_RepairedPart] (
        [Id] int NOT NULL IDENTITY,
        [ReportId] int NOT NULL,
        [RepairedPartId] int NOT NULL,
        CONSTRAINT [PK_Report_RepairedPart] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Report_RepairedPart_RepairedPart_RepairedPartId] FOREIGN KEY ([RepairedPartId]) REFERENCES [RepairedPart] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Report_RepairedPart_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE TABLE [Report_ReplacedPart] (
        [Id] int NOT NULL IDENTITY,
        [ReportId] int NOT NULL,
        [ReplacedPartId] int NOT NULL,
        CONSTRAINT [PK_Report_ReplacedPart] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Report_ReplacedPart_ReplacedPart_ReplacedPartId] FOREIGN KEY ([ReplacedPartId]) REFERENCES [ReplacedPart] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Report_ReplacedPart_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE INDEX [IX_Repairs_Tools_RepairId] ON [Repairs_Tools] ([RepairId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE INDEX [IX_Repairs_Tools_ToolId] ON [Repairs_Tools] ([ToolId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE INDEX [IX_Report_ProductId] ON [Report] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE INDEX [IX_Report_RepairedPart_RepairedPartId] ON [Report_RepairedPart] ([RepairedPartId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE INDEX [IX_Report_RepairedPart_ReportId] ON [Report_RepairedPart] ([ReportId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE INDEX [IX_Report_ReplacedPart_ReplacedPartId] ON [Report_ReplacedPart] ([ReplacedPartId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE INDEX [IX_Report_ReplacedPart_ReportId] ON [Report_ReplacedPart] ([ReportId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    CREATE INDEX [IX_Steps_RepairId] ON [Steps] ([RepairId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525105555_InitialMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210525105555_InitialMigration', N'5.0.6');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Report] DROP CONSTRAINT [FK_Report_Product_ProductId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Report_RepairedPart] DROP CONSTRAINT [FK_Report_RepairedPart_Report_ReportId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Report_ReplacedPart] DROP CONSTRAINT [FK_Report_ReplacedPart_Report_ReportId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Report] DROP CONSTRAINT [PK_Report];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Product] DROP CONSTRAINT [PK_Product];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    EXEC sp_rename N'[Report]', N'Reports';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    EXEC sp_rename N'[Product]', N'Products';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    EXEC sp_rename N'[Reports].[IX_Report_ProductId]', N'IX_Reports_ProductId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Reports] ADD CONSTRAINT [PK_Reports] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Products] ADD CONSTRAINT [PK_Products] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Report_RepairedPart] ADD CONSTRAINT [FK_Report_RepairedPart_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Report_ReplacedPart] ADD CONSTRAINT [FK_Report_ReplacedPart_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    ALTER TABLE [Reports] ADD CONSTRAINT [FK_Reports_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525124218_ReportProductControllersAndServices')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210525124218_ReportProductControllersAndServices', N'5.0.6');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Report_RepairedPart] DROP CONSTRAINT [FK_Report_RepairedPart_RepairedPart_RepairedPartId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Report_RepairedPart] DROP CONSTRAINT [FK_Report_RepairedPart_Reports_ReportId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Report_ReplacedPart] DROP CONSTRAINT [FK_Report_ReplacedPart_ReplacedPart_ReplacedPartId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Report_ReplacedPart] DROP CONSTRAINT [FK_Report_ReplacedPart_Reports_ReportId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Report_ReplacedPart] DROP CONSTRAINT [PK_Report_ReplacedPart];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Report_RepairedPart] DROP CONSTRAINT [PK_Report_RepairedPart];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    EXEC sp_rename N'[Report_ReplacedPart]', N'Reports_ReplacedParts';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    EXEC sp_rename N'[Report_RepairedPart]', N'Reports_RepairedParts';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    EXEC sp_rename N'[Reports_ReplacedParts].[IX_Report_ReplacedPart_ReportId]', N'IX_Reports_ReplacedParts_ReportId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    EXEC sp_rename N'[Reports_ReplacedParts].[IX_Report_ReplacedPart_ReplacedPartId]', N'IX_Reports_ReplacedParts_ReplacedPartId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    EXEC sp_rename N'[Reports_RepairedParts].[IX_Report_RepairedPart_ReportId]', N'IX_Reports_RepairedParts_ReportId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    EXEC sp_rename N'[Reports_RepairedParts].[IX_Report_RepairedPart_RepairedPartId]', N'IX_Reports_RepairedParts_RepairedPartId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Reports_ReplacedParts] ADD CONSTRAINT [PK_Reports_ReplacedParts] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Reports_RepairedParts] ADD CONSTRAINT [PK_Reports_RepairedParts] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Reports_RepairedParts] ADD CONSTRAINT [FK_Reports_RepairedParts_RepairedPart_RepairedPartId] FOREIGN KEY ([RepairedPartId]) REFERENCES [RepairedPart] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Reports_RepairedParts] ADD CONSTRAINT [FK_Reports_RepairedParts_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Reports_ReplacedParts] ADD CONSTRAINT [FK_Reports_ReplacedParts_ReplacedPart_ReplacedPartId] FOREIGN KEY ([ReplacedPartId]) REFERENCES [ReplacedPart] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    ALTER TABLE [Reports_ReplacedParts] ADD CONSTRAINT [FK_Reports_ReplacedParts_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525131304_Adjustments')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210525131304_Adjustments', N'5.0.6');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525135622_ProductRepairRelationship')
BEGIN
    ALTER TABLE [Repairs] ADD [ProductId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525135622_ProductRepairRelationship')
BEGIN
    CREATE INDEX [IX_Repairs_ProductId] ON [Repairs] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525135622_ProductRepairRelationship')
BEGIN
    ALTER TABLE [Repairs] ADD CONSTRAINT [FK_Repairs_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210525135622_ProductRepairRelationship')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210525135622_ProductRepairRelationship', N'5.0.6');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    ALTER TABLE [Reports_RepairedParts] DROP CONSTRAINT [FK_Reports_RepairedParts_RepairedPart_RepairedPartId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    ALTER TABLE [Reports_ReplacedParts] DROP CONSTRAINT [FK_Reports_ReplacedParts_ReplacedPart_ReplacedPartId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    ALTER TABLE [ReplacedPart] DROP CONSTRAINT [PK_ReplacedPart];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    ALTER TABLE [RepairedPart] DROP CONSTRAINT [PK_RepairedPart];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    EXEC sp_rename N'[ReplacedPart]', N'ReplacedParts';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    EXEC sp_rename N'[RepairedPart]', N'RepairedParts';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    ALTER TABLE [ReplacedParts] ADD CONSTRAINT [PK_ReplacedParts] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    ALTER TABLE [RepairedParts] ADD CONSTRAINT [PK_RepairedParts] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    ALTER TABLE [Reports_RepairedParts] ADD CONSTRAINT [FK_Reports_RepairedParts_RepairedParts_RepairedPartId] FOREIGN KEY ([RepairedPartId]) REFERENCES [RepairedParts] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    ALTER TABLE [Reports_ReplacedParts] ADD CONSTRAINT [FK_Reports_ReplacedParts_ReplacedParts_ReplacedPartId] FOREIGN KEY ([ReplacedPartId]) REFERENCES [ReplacedParts] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210608192142_RepairedReplacedParts')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210608192142_RepairedReplacedParts', N'5.0.6');
END;
GO

COMMIT;
GO

