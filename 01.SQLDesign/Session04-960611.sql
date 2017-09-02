USE AdventureWorks2016CTP3
---------------
SELECT 'John' + 'Doe'
---------------
SELECT FirstName , MiddleName , LastName,
FirstName + MiddleName + LastName 'FullName'
FROM Person.Person
---------------
SELECT FirstName , MiddleName , LastName,
CONCAT(FirstName , ' ' , MiddleName, ' ' ,LastName) 'FullName'
FROM Person.Person
---------------
SELECT SUBSTRING(Name, 1, 2)
FROM Production.Product
---------------
SELECT SUBSTRING('John Doe', 1, 2)
---------------
SELECT LEFT(Name, 4), RIGHT(Name, 2)
FROM Production.Product
---------------
SELECT LEFT(Name, 4), RIGHT(Name, 2)
FROM Production.Product
---------------
SELECT LEN('John Doe')
---------------
SELECT SUBSTRING(Name, LEN(Name) - 2, 3)
FROM Production.Product
---------------
SELECT '1396-06-11', REPLACE('1396-06-11','-', '/')
---------------
SELECT REPLICATE('A', 10)
---------------
SELECT UPPER(Name), LOWER(Name)
FROM Production.Product
----------------
SELECT '           John Doe           ', LTRIM('           John Doe           ')
----------------
SELECT '           John Doe           ', RTRIM('           John Doe           ')
----------------
SELECT Name, Color, 
CASE ISNULL(Color, 'NoColor')
WHEN 'Red' THEN N'قرمز'
WHEN 'Blue' THEN N'آبی'
WHEN 'Black' THEN N'مشکی'
WHEN 'NoColor' THEN N'بدون رنگ'
ELSE N'رنگی'
END 'PersianColor'
FROM Production.Product
-----------------
SELECT p.ProductId, p.Name, --SUM(s.OrderQty) 'SumQty',
CASE 
WHEN SUM(s.OrderQty) >= 1000 THEN N'پرفروش'
WHEN SUM(s.OrderQty) BETWEEN 100 AND 999 THEN N'فروش متوسط'
WHEN SUM(s.OrderQty) < 100 THEN N'کم فروش'
ELSE N'بدون فروش'
END 'SumQtyText'
FROM Production.Product p
FULL OUTER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, p.Name
ORDER BY SUM(s.OrderQty) DESC
----------------------
SELECT STUFF('John Doe', 1, 4, 'David')
----------------------
SELECT STUFF('951478595', 1, 2, '96'), REPLACE('951478595', '95','96')
-----------------------
SELECT AVG(OrderQty) 
FROM Sales.SalesOrderDetail
-----------------------
SELECT ProductId, AVG(SUM(OrderQty))
FROM Sales.SalesOrderDetail
GROUP BY ProductID
-----------------------
SELECT ROW_NUMBER() OVER(ORDER BY Name)'Row', ProductId, Name, Color
FROM Production.Product
WHERE ROW_NUMBER() OVER(ORDER BY Name) BETWEEN 11 AND 20
------------------------
WITH CTE
AS
(
SELECT ROW_NUMBER() OVER(ORDER BY Name)'Row', ProductId, Name, Color
FROM Production.Product
)
SELECT *
FROM CTE
WHERE Row BETWEEN 11 AND 20
-------------------------
DECLARE @PN INT
DECLARE @RPP INT
SET @PN = 3
SET @RPP = 10;
WITH CTE
AS
(
SELECT ROW_NUMBER() OVER(ORDER BY Name)'Row', ProductId, Name, Color
FROM Production.Product
)
SELECT *
FROM CTE
WHERE Row BETWEEN ((@PN -1) * @RPP) + 1 AND @PN * @RPP
--------------------
SELECT AVG(SumQty)
FROM
(
SELECT ProductId, SUM(OrderQty) 'SumQty'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
) AS t
---------------------
SELECT ProductId, Name, Color, 
(
	SELECT SUM(LineTotal)
	FROM Sales.SalesOrderDetail
) 'TotalSales'
FROM Production.Product
---------------------
SELECT ProductId, Name, Color,
(
	SELECT SUM(LineTotal)
	FROM Sales.SalesOrderDetail s
	WHERE p.ProductID = s.ProductID
) 'TotalProductSales',
(
	SELECT SUM(LineTotal)
	FROM Sales.SalesOrderDetail
) 'TotalSales',
(
	SELECT SUM(LineTotal)
	FROM Sales.SalesOrderDetail s
	WHERE p.ProductID = s.ProductID
) 
/ ------------------> IN TAGHSIM AST
(
	SELECT SUM(LineTotal)
	FROM Sales.SalesOrderDetail
) 'PercentOfTotalSales'

FROM Production.Product p
ORDER BY PercentOfTotalSales DESC
----------------------
SELECT ProductId, Name, Color
FROM Production.Product 
WHERE ProductID IN 
(
	SELECT DISTINCT Productid 
	FROM Sales.SalesOrderDetail
)
UNION
SELECT ProductId, Name, Color
FROM Production.Product
WHERE Color = 'Red'
------------------------
SELECT ProductId, Name, Color
FROM Production.Product 
WHERE ProductID IN 
(
	SELECT DISTINCT Productid 
	FROM Sales.SalesOrderDetail
)
UNION ALL
SELECT ProductId, Name, Color
FROM Production.Product
WHERE Color = 'Red'
-------------------------
SELECT ProductId, Name, Color
FROM Production.Product 
WHERE ProductID IN 
(
	SELECT DISTINCT Productid 
	FROM Sales.SalesOrderDetail
)
INTERSECT
SELECT ProductId, Name, Color
FROM Production.Product
WHERE Color = 'Red'
-------------------
SELECT ProductId, Name, Color
FROM Production.Product 
WHERE ProductID IN 
(
	SELECT DISTINCT Productid 
	FROM Sales.SalesOrderDetail
)
EXCEPT
SELECT ProductId, Name, Color
FROM Production.Product
WHERE Color = 'Red'
----------------------
CREATE DATABASE Session04
----------------------
USE Session04
----------------------
CREATE TABLE Student
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	Family NVARCHAR(50),
	BirthDate DATETIME
)
----------------------
INSERT INTO Student(Name,Family, BirthDate)
VALUES(N'رضا', N'رضایی', '1980/10/10'),
(N'علی', N'علیان', '1970/10/10'),
(N'مینا', N'مینایی', '1970/10/10'),
(N'سارا', N'سارایی', '1960/10/10')
----------------------
SELECT * FROM Student
----------------------
INSERT INTO Student
VALUES(N'پیام', N'پیامی', '1980/10/10'),
(N'پویا', N'پویایی', '1970/10/10')
-----------------------
INSERT INTO Student(Name, Family)
SELECT FirstName, LastName
FROM AdventureWorks2016CTP3.Person.Person
-----------------------
SELECT * FROM Student
-----------------------
SELECT ProductId, Name, Color, ListPrice
INTO Product
FROM AdventureWorks2016CTP3.Production.Product

-----------------------
SELECT * FROM Product
-----------------------
SELECT p.ProductId, Name, Color, ListPrice, SUM(s.OrderQty) 'SumQty'
INTO Product
FROM AdventureWorks2016CTP3.Production.Product p
LEFT OUTER JOIN AdventureWorks2016CTP3.Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, Name, Color, ListPrice
