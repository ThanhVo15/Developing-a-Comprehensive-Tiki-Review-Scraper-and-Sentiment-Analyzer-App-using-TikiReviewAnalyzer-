-- Cào thêm dữ liệu khách hàng để khi bấm vào show ra khách hàng nào nhấn 

USE TikiReviewAnalyzer;
GO

-- Create schema Users
CREATE SCHEMA Users;
GO

-- Create schema Tiki
CREATE SCHEMA Tiki;
GO

-- Create Table Account
CREATE TABLE Users.Account(
    AccID INT IDENTITY(1,1) PRIMARY KEY,
    AccFirstName NVARCHAR(50) NOT NULL,
    AccLastName NVARCHAR(50) NOT NULL,
    AccEmail NVARCHAR(100) UNIQUE NOT NULL,
    AccPhoneNumber NVARCHAR(15) UNIQUE NOT NULL,
    AccDateOfBirth DATE,
    AccUserName NVARCHAR(20) UNIQUE NOT NULL,
    AccPassword NVARCHAR(256) NOT NULL
);

-- Create Table User Info/DATA
CREATE TABLE Users.Info(
    IDData INT IDENTITY(1,1) PRIMARY KEY,
    AccID INT NOT NULL,
    DataName NVARCHAR(MAX) NOT NULL,
    DataDescription NVARCHAR(MAX),
    DateScrape DATETIME,
    FOREIGN KEY (AccID) REFERENCES Users.Account(AccID)
);

-- Create Table User Model
CREATE TABLE Users.Model(
    IDModel INT IDENTITY(1,1) PRIMARY KEY,
    AccID INT NOT NULL,
    ModelName NVARCHAR(MAX) NOT NULL,
    ModelDescription NVARCHAR(MAX),
    DateCreate DATETIME,
    FOREIGN KEY (AccID) REFERENCES Users.Account(AccID)
);

-- Create Table ProductCategory
CREATE TABLE Tiki.ProductCategory(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ProductCategoryID VARCHAR(50) UNIQUE NOT NULL,
    ProductCategoryText NVARCHAR(MAX) NOT NULL,
    ProductCategoryLink NVARCHAR(MAX) NOT NULL
);

-- Create Table Products
CREATE TABLE Tiki.Products(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ProductCategoryID VARCHAR(50),
    ProductID NVARCHAR(50) NOT NULL UNIQUE,
    ProductSKU NVARCHAR(50) NOT NULL,
    ProductName NVARCHAR(MAX) NOT NULL, 
    ProductOriginalPrice INT NOT NULL,
    ProductPrice INT NOT NULL,
    ProductQuantitySold INT NOT NULL,
    RatingAverage DECIMAL(3,2) NOT NULL,
    ReviewCount INT,
    EarliestDeliveryEstimate INT,
    StandardDeliveryEstimate INT,
    UrlPath NVARCHAR(MAX),
    AccID INT NOT NULL,
    IDData INT,
    FOREIGN KEY (ProductCategoryID) REFERENCES Tiki.ProductCategory(ProductCategoryID),
    FOREIGN KEY (AccID) REFERENCES Users.Account(AccID),
    FOREIGN KEY (IDData) REFERENCES Users.Info(IDData)
);

-- Create Table ProductDetail
CREATE TABLE Tiki.ProductDetail(
    ID INT IDENTITY(0,1) PRIMARY KEY,
    ProductID NVARCHAR(50) NOT NULL,
    ProdDescriptions NVARCHAR(MAX),
    ProdShortDescriptions NVARCHAR(MAX),
    ProdURL NVARCHAR(MAX),
    FOREIGN KEY (ProductID) REFERENCES Tiki.Products(ProductID)
);

-- Create Table Review
CREATE TABLE Tiki.Review(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID NVARCHAR(50) NOT NULL,
    ReviewID INT,
    Title NVARCHAR(MAX),
    Content NVARCHAR(MAX),
    Created_Time DATETIME,
    CustomerID NVARCHAR(50),
    ImagesURL NVARCHAR(MAX),
    Rating INT,
    FOREIGN KEY (ProductID) REFERENCES Tiki.Products(ProductID)
);

-- Create Table Review GPT Category
CREATE TABLE Tiki.ReviewGPTCate(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID NVARCHAR(50) NOT NULL,
    title NVARCHAR(MAX),
    sub_title NVARCHAR(MAX),
    FOREIGN KEY (ProductID) REFERENCES Tiki.Products(ProductID)
);

-- Create Table Review GPT
CREATE TABLE Tiki.ReviewGPT(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    GPTCateID INT,
    texts NVARCHAR(MAX),
    FOREIGN KEY (GPTCateID) REFERENCES Tiki.ReviewGPTCate(ID)
);
