CREATE TABLE users 
(
 id INT PRIMARY KEY IDENTITY (1,1),
 username VARCHAR (MAX) NULL,
 password VARCHAR (MAX) NULL,
 status VARCHAR (MAX) NULL,
 date_created DATE NULL
)
Insert into users (username, password, status, date_created) Values ('admin', 'admin123', 'Admin', '2025-01-24')

Select * from users

CREATE TABLE categories 
(
id INT PRIMARY KEY IDENTITY (1,1),
 category VARCHAR (MAX) NULL,
 status VARCHAR (MAX) NULL,
 date_insert DATE NULL
)
select * from categories

CREATE TABLE products 
(
 id INT PRIMARY KEY IDENTITY (1,1),
 productid VARCHAR (MAX) NULL,
 productname VARCHAR (MAX) NULL,
 category VARCHAR (MAX) NULL,
 stock INT NULL,
 price FLOAT,
 status VARCHAR (MAX) NULL,
 image VARCHAR(MAX) NULL,
 date_insert DATE NULL,
 date_update DATE NULL
)

select * from products