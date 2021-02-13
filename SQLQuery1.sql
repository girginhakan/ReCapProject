create table Users(
UserId int primary key identity(1,1),
FirstName nvarchar(50),
LastName nvarchar(50),
Email nvarchar(50),
Password nvarchar(50)
)

create table Customers(
CustomerId int primary key identity(1,1),
UserId int foreign key references Users(UserId),
CompanyName nvarchar(50) 
)