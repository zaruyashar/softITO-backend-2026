
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/22/2026 10:55:33
-- Generated from EDMX file: C:\ITO Konsol Uygulamaları\SoftITO-Backend\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Soft3];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Ogrencis'
CREATE TABLE [dbo].[Ogrencis] (
    [OgrenciNo] int IDENTITY(1,1) NOT NULL,
    [AdSoyadi] nvarchar(max)  NOT NULL,
    [Yas] int  NOT NULL
);
GO

-- Creating table 'Derslers'
CREATE TABLE [dbo].[Derslers] (
    [DersNo] int IDENTITY(1,1) NOT NULL,
    [DersKredisi] int  NOT NULL,
    [DersAKTS] int  NOT NULL,
    [OgrenciNo] int  NOT NULL,
    [OgrenciOgrenciNo] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [OgrenciNo] in table 'Ogrencis'
ALTER TABLE [dbo].[Ogrencis]
ADD CONSTRAINT [PK_Ogrencis]
    PRIMARY KEY CLUSTERED ([OgrenciNo] ASC);
GO

-- Creating primary key on [DersNo] in table 'Derslers'
ALTER TABLE [dbo].[Derslers]
ADD CONSTRAINT [PK_Derslers]
    PRIMARY KEY CLUSTERED ([DersNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [OgrenciOgrenciNo] in table 'Derslers'
ALTER TABLE [dbo].[Derslers]
ADD CONSTRAINT [FK_OgrenciDersler]
    FOREIGN KEY ([OgrenciOgrenciNo])
    REFERENCES [dbo].[Ogrencis]
        ([OgrenciNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OgrenciDersler'
CREATE INDEX [IX_FK_OgrenciDersler]
ON [dbo].[Derslers]
    ([OgrenciOgrenciNo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------