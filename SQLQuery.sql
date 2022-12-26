CREATE TABLE Products
(
	"Id" INT PRIMARY KEY,
	"Category_Id" INT,
	"Name" nchar(10)
);

INSERT INTO Products
VALUES
	(5, 3, 'Cucumber'), 
	(6, 2, 'Chips'), 
	(7, NULL, 'Apple'), 
	(8, 1, 'Soda');    

CREATE TABLE Categories
(
	"Id" INT PRIMARY KEY,
	"Name" nchar(10)
);

INSERT INTO Categories
VALUES
	(1, 'Drinks'),
	(2, 'Snacks'),
	(3, 'Vegetables');

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN Categories C
ON P.Category_Id = C.Id