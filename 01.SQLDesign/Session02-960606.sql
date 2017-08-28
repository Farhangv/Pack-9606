USE AdventureWorks2016CTP3
----------------
SELECT TOP 10 ProductId,Name, Color, ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
----------------
SELECT TOP 10 PERCENT ProductId,Name, Color, ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
----------------
SELECT TOP 13 WITH TIES
ProductId,Name, Color, ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
----------------
SELECT DISTINCT Color
FROM Production.Product
----------------
SELECT ISNULL(Color, N'بدون رنگ') 'Color'
FROM Production.Product
----------------
SELECT DISTINCT ISNULL(Color, N'بدون رنگ') 'Color'
FROM Production.Product
-----------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Color = 'Black'
-----------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ListPrice != 0
-----------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ListPrice != 0 AND Color = 'Black'
-----------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ListPrice != 0 OR Color = 'Black'
-----------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
--WHERE ListPrice >= 1000 AND ListPrice <= 2000
WHERE ListPrice BETWEEN 1000 AND 2000
ORDER BY ListPrice
------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Color IS NULL
------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Color IS NOT NULL
------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE 'a%'
------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '%e'
------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '%Bike%'
------------------
DECLARE @SearchPhrase NVARCHAR(50)
SET @SearchPhrase = 'Bike'
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '%'+@SearchPhrase+'%'
------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '__a%'
------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '[pth]a%'
-------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '%\]%' ESCAPE '\'
-------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
--WHERE ProductID = 1 OR ProductID = 2 OR ProductId = 712
WHERE ProductID IN (1,2,712)
-------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
--WHERE ProductID = 1 OR ProductID = 2 OR ProductId = 712
WHERE ProductID NOT IN (1,2,712)
--------------------
SELECT * 
FROM Sales.SalesOrderHeader
--------------------
SELECT * 
FROM Sales.SalesOrderDetail
--------------------
SELECT DISTINCT ProductId 
FROM Sales.SalesOrderDetail
---------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID IN (
	SELECT DISTINCT ProductId 
	FROM Sales.SalesOrderDetail
)
---------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID NOT IN (
	SELECT DISTINCT ProductId 
	FROM Sales.SalesOrderDetail
)
----------------------
SELECT GETDATE()
----------------------
SELECT ProductId, Name, ListPrice ,ModifiedDate, GETDATE()
FROM Production.Product
----------------------
SELECT ProductId, LEFT(Name,2), ListPrice ,ModifiedDate
FROM Production.Product
----------------------
SELECT COUNT(*)
FROM Production.Product
----------------------
SELECT COUNT(Name)
FROM Production.Product
----------------------
SELECT COUNT(Color)
FROM Production.Product
----------------------
SELECT COUNT(Color), COUNT(Name)
FROM Production.Product
----------------------
SELECT COUNT(Color), COUNT(Name), MIN(ListPrice)
FROM Production.Product
----------------------
SELECT COUNT(Color), 
COUNT(Name), 
MIN(Color),
MIN(ListPrice), 
MAX(ListPrice),
SUM(ListPrice),
AVG(ListPrice),
VAR(ListPrice)
FROM Production.Product
------------------
SELECT SUM(OrderQty * UnitPrice * (1 - UnitPriceDiscount))
FROM Sales.SalesOrderDetail
------------------
SELECT ProductId, SUM(LineTotal)
FROM Sales.SalesOrderDetail
GROUP BY ProductId
-------------------
SELECT ProductId, SalesOrderDetailID, SUM(LineTotal)
FROM Sales.SalesOrderDetail
GROUP BY ProductId, SalesOrderDetailID
-------------------
SELECT ProductId, SUM(LineTotal) 'Sum', MIN(LineTotal) 'Min', MAX(LineTotal) 'Max'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
-------------------
SELECT ProductId, SUM(LineTotal) 'Sum', MIN(LineTotal) 'Min', MAX(LineTotal) 'Max'
FROM Sales.SalesOrderDetail
--WHERE SUM(LineTotal) BETWEEN 100000 AND 150000
GROUP BY ProductId
HAVING SUM(LineTotal) BETWEEN 100000 AND 150000
-------------------
SELECT SUM(LineTotal)
FROM Sales.SalesOrderDetail
WHERE ProductID = 777
-------------------
SELECT ProductId, SUM(LineTotal) 'Sum', MIN(LineTotal) 'Min', MAX(LineTotal) 'Max'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
HAVING SUM(LineTotal) BETWEEN 100000 AND 150000
ORDER BY [Sum] DESC
--------------------







