
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/23/2026 08:40:49
-- Generated from EDMX file: C:\ITO Konsol Uygulamaları\SoftITO-Backend\DORDUNCU-PROJE\DORDUNCUPROJE.edmx
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

-- Creating table 'Araclars'
CREATE TABLE [dbo].[Araclars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Plaka] nvarchar(max)  NOT NULL,
    [Marka] nvarchar(max)  NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [Yil] int  NOT NULL
);
GO

-- Creating table 'Subelers'
CREATE TABLE [dbo].[Subelers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SubeAdi] nvarchar(max)  NOT NULL,
    [Sehir] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Kullanicilars'
CREATE TABLE [dbo].[Kullanicilars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [KullaniciAdi] nvarchar(max)  NOT NULL,
    [Sifre] nvarchar(max)  NOT NULL,
    [AdSoyadi] nvarchar(max)  NOT NULL,
    [Rol] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Musterilers'
CREATE TABLE [dbo].[Musterilers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AdSoyadi] nvarchar(max)  NOT NULL,
    [TcKimlik] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Eposta] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Araclars'
ALTER TABLE [dbo].[Araclars]
ADD CONSTRAINT [PK_Araclars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Subelers'
ALTER TABLE [dbo].[Subelers]
ADD CONSTRAINT [PK_Subelers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Kullanicilars'
ALTER TABLE [dbo].[Kullanicilars]
ADD CONSTRAINT [PK_Kullanicilars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Musterilers'
ALTER TABLE [dbo].[Musterilers]
ADD CONSTRAINT [PK_Musterilers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------