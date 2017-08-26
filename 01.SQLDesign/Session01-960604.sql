CREATE DATABASE Session01
----------
SelECT 123
----------
SELECT 'Hello'
----------
SELECT N'سلام'
----------
SELECT @@CONNECTIONS
----------
DECLARE @Name NVARCHAR(50)
SELECT @Name = 'John'
SELECT @Name 
----------
SELECT GETDATE()
----------
USE AdventureWorks2016CTP3
----------
SELECT *
FROM Production.Product
----------
SELECT ProductID, [Name], Color, StandardCost, ListPrice, ProductSubCategoryId, ModifiedDate
FROM Production.Product
----------
SELECT ProductID AS شناسه, [Name] AS 'نام محصول', Color رنگ, StandardCost 'هزینه تولید', ListPrice, ProductSubCategoryId, ModifiedDate
FROM Production.Product
----------
SELECT ProductID, [Name], Color, StandardCost, ListPrice, (ListPrice - StandardCost) 'Benefit', ProductSubCategoryId, ModifiedDate
FROM Production.Product
---------
SELECT ProductID, [Name], Color, StandardCost, ListPrice, ProductSubCategoryId, ModifiedDate
FROM Production.Product
---------
SELECT ProductID, [Name], Color, StandardCost, ListPrice, ProductSubCategoryId, ModifiedDate
FROM Production.Product
ORDER BY Color, Name
---------
SELECT ProductID, [Name], Color, StandardCost, ListPrice, ProductSubCategoryId, ModifiedDate
FROM Production.Product
ORDER BY 2 DESC
---------
SELECT ProductID, [Name], Color, StandardCost, ListPrice, ProductSubCategoryId, ModifiedDate
FROM Production.Product
ORDER BY Color DESC, ListPrice DESC


