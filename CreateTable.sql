CREATE TABLE IF NOT EXISTS Products (
	Id INT PRIMARY KEY,
	Name VARCHAR(100)
);

INSERT INTO Products
VALUES
	(1, 'Iphone 15'),
	(2, 'Mustang'),
	(3, 'Apple');
    
CREATE TABLE IF NOT EXISTS Categories (
	Id INT PRIMARY KEY,
	Name varchar(100)
);

INSERT INTO Categories
VALUES
	(1, 'Phones'),
	(2, 'Tools'),
	(3, 'Electronics');

CREATE TABLE IF NOT EXISTS ProductCategories (
	ProductId INT,
	CategoryId INT,
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 3),
	(1, 1),
	(2, 2);