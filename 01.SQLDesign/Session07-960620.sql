CREATE DATABASE Session07
GO
USE Session07
GO
CREATE TABLE Teacher
(
	Id INT PRIMARY KEY,
	Name NVARCHAR(50),
	Family NVARCHAR(50)
)
GO
CREATE TABLE Course
(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(50),
	TeacherId INT DEFAULT 1,
	CONSTRAINT FK_TeacherId FOREIGN KEY(TeacherId) REFERENCES Teacher(Id)
	ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO
USE AdventureWorks2016CTP3
GO
CREATE VIEW VW_SalesBrief
AS
	SELECT ROW_NUMBER() OVER (ORDER BY p.Name) 'Row', p.ProductId, p.Name,
	SUM(s.LineTotal) 'TotalSalesAmount', SUM(s.OrderQty) 'TotalSalesQuantity'
	FROM Production.Product p
	INNER JOIN Sales.SalesOrderDetail s
	ON p.ProductID = s.ProductID
	GROUP BY p.ProductId, p.Name

GO
SELECT * 
FROM VW_SalesBrief
GO
