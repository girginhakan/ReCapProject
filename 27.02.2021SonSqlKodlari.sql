CREATE TABLE Cars (
    CarId int NOT NULL,
    BrandId int NOT NULL,
    ColorId int NOT NULL,
    CarName varchar(255) NOT NULL,
    ModelYear varchar(255) NOT NULL,
    DailyPrice decimal(18) NOT NULL,
    Description varchar(255) NOT NULL,
    CONSTRAINT PK_Cars PRIMARY KEY (CarId)
);

CREATE TABLE Brands (
    BrandId int NOT NULL,
    BrandName varchar(255) NOT NULL,
    CONSTRAINT PK_Brands PRIMARY KEY (BrandId)
);

CREATE TABLE Colors (
    ColorId int NOT NULL,
    ColorName varchar(255) NOT NULL,
    CONSTRAINT PK_Colors PRIMARY KEY (ColorId)
);

CREATE TABLE Users (
    UserId int NOT NULL,
    FirstName varchar(255) NOT NULL,
    LastName varchar(255) NOT NULL,
    Email varchar(255) NOT NULL,
    Password varchar(255) NOT NULL,
    CONSTRAINT PK_Users PRIMARY KEY (UserId)
);

CREATE TABLE Customers (
    CustomerId int NOT NULL,
    CompanyName varchar(255) NOT NULL,
    CONSTRAINT PK_Customers PRIMARY KEY (CustomerId),
    FOREIGN KEY (CustomerId) REFERENCES Users(UserId)
);

CREATE TABLE Rentals (
    RentId int NOT NULL,
    CarId int NOT NULL,
    CustomerId int NOT NULL,
    RentDate varchar(255) NOT NULL,
    ReturnDate varchar(255) DEFAULT NULL,
    CONSTRAINT PK_Rentals PRIMARY KEY (RentId),
    FOREIGN KEY (CarId) REFERENCES Cars(CarId),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);

CREATE TABLE CarImages (
    CarImageId int NOT NULL,
    CarId int NOT NULL,
    ImagePath varchar(255) NOT NULL,
    ImageDate datetime DEFAULT GETDATE(),
    CONSTRAINT PK_CarImages PRIMARY KEY (CarImageId),
    FOREIGN KEY (CarId) REFERENCES Cars(CarId)
);