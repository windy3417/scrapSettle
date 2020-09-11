
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/09/2020 11:52:09
-- Generated from EDMX file: E:\code\scrapSettle\scrapSettlement\DAL\WeighingSettlementModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [scrapSettle];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_WeighingSettlementCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WeighingSettlementSet] DROP CONSTRAINT [FK_WeighingSettlementCustomer];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[WeighingSettlementSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WeighingSettlementSet];
GO
IF OBJECT_ID(N'[dbo].[CustomerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'WeighingSettlementSet'
CREATE TABLE [dbo].[WeighingSettlementSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [vocherNO] nvarchar(10)  NOT NULL,
    [CustmerCode] nvarchar(10)  NOT NULL,
    [personCode] nvarchar(10)  NOT NULL,
    [scrapCode] nvarchar(10)  NOT NULL,
    [netWeight] float  NOT NULL,
    [proportion] float  NOT NULL,
    [webUnitPrice] float  NOT NULL,
    [settleUnitPrice] float  NOT NULL,
    [settleAmount] float  NOT NULL,
    [Customer_Id] int  NOT NULL
);
GO

-- Creating table 'CustomerSet'
CREATE TABLE [dbo].[CustomerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [cusCode] nvarchar(10)  NOT NULL,
    [cusName] nvarchar(50)  NOT NULL,
    [effectDate] datetime  NOT NULL,
    [failuerDate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'WeighingSettlementSet'
ALTER TABLE [dbo].[WeighingSettlementSet]
ADD CONSTRAINT [PK_WeighingSettlementSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CustomerSet'
ALTER TABLE [dbo].[CustomerSet]
ADD CONSTRAINT [PK_CustomerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customer_Id] in table 'WeighingSettlementSet'
ALTER TABLE [dbo].[WeighingSettlementSet]
ADD CONSTRAINT [FK_WeighingSettlementCustomer]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[CustomerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WeighingSettlementCustomer'
CREATE INDEX [IX_FK_WeighingSettlementCustomer]
ON [dbo].[WeighingSettlementSet]
    ([Customer_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------