CREATE TABLE orders 
(
id INT PRIMARY KEY IDENTITY (1,1),
customerId VARCHAR(MAX) NULL,
productids VARCHAR(MAX) NULL,
quantities VARCHAR(MAX) NULL,
prices VARCHAR(MAX) NULL,
total VARCHAR(MAX) NULL,
date_order DATE NULL

)

SELECT * FROM orders
SELECT * FROM products