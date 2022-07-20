CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name VARCHAR(20)
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name VARCHAR(20)
);

CREATE TABLE Connections (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN Connections
	ON Products.Id = Connections.ProductId
LEFT JOIN Categories
	ON Connections.CategoryId = Categories.Id;