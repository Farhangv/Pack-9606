USE AdventureWorks2016CTP3
----------------
SELECT ROW_NUMBER() OVER(ORDER BY Name) 'Row' ,ProductId, Name, Color, ListPrice
FROM Production.Product
----------------
SELECT ROW_NUMBER() OVER(ORDER BY Name) 'Row' ,ProductId, Name, Color, ListPrice
FROM Production.Product
ORDER BY ProductId
----------------
SELECT RANK() OVER(ORDER BY ListPrice DESC) 'Rank' ,ProductId, Name, Color, ListPrice
FROM Production.Product
----------------
SELECT DENSE_RANK() OVER(ORDER BY ListPrice DESC) 'DenseRank' ,ProductId, Name, Color, ListPrice
FROM Production.Product
----------------
SELECT NTILE(5) OVER(ORDER BY ProductId) 'Tile' ,ProductId, Name, Color, ListPrice
FROM Production.Product
----------------
SELECT ROW_NUMBER() OVER(PARTITION BY Color ORDER BY Name) 'Row' ,ProductId, Name, Color, ListPrice
FROM Production.Product
----------------
SELECT p.ProductId, p.Name , s.OrderQty, UnitPrice, UnitPriceDiscount, LineTotal
FROM Production.Product p
INNER JOIN Sales.SalesOrderDetail s
ON s.ProductId = p.ProductId
-----------------
SELECT ProductId, p.Name 'ProductName', Color, sc.Name 'SubCategoryName'
FROM Production.Product p
INNER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
-----------------
SELECT ProductId, 
p.Name 'ProductName', 
Color, 
sc.Name 'SubCategoryName',
c.Name 'CategoryName'
FROM Production.Product p
INNER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
JOIN Production.ProductCategory c
ON sc.ProductCategoryID = c.ProductCategoryID
---------------
SELECT ProductId, 
p.Name 'ProductName', 
Color, 
sc.Name 'SubCategoryName'
FROM Production.Product p
LEFT OUTER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
---------------
SELECT ProductId, 
p.Name 'ProductName', 
Color, 
sc.Name 'SubCategoryName'
FROM Production.Product p
RIGHT OUTER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
---------------
SELECT ProductId, 
p.Name 'ProductName', 
Color, 
sc.Name 'SubCategoryName'
FROM Production.Product p
FULL OUTER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
----------------------
SELECT sc.Name, ISNULL(SUM(s.LineTotal),0) 'Sum'
FROM Production.ProductSubcategory sc
LEFT OUTER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
LEFT OUTER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY sc.Name
---------------------
SELECT c.Name, ISNULL(SUM(s.LineTotal),0) 'Sum'
FROM Production.ProductCategory c
LEFT OUTER JOIN Production.ProductSubcategory sc
ON sc.ProductCategoryID = c.ProductCategoryID
LEFT OUTER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
LEFT OUTER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY c.Name
-----------------------
CREATE DATABASE Session03
-----------------------
USE Session03
-----------------------
CREATE TABLE Course
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50)
)
-----------------------
CREATE TABLE Student
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50)
)
-----------------------
INSERT INTO Course VALUES ('SQL'), ('C#') , ('Math'), ('JavaScript')
-----------------------
INSERT INTO Student VALUES ('John Doe'), ('Sarah Smith'), ('David Doe')
-----------------------
SELECT c.Name, s.FullName
FROM Course c
CROSS JOIN Student s
------------------------
CREATE TABLE Employee
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50),
	Position NVARCHAR(50),
	ManagerId INT
)
--------------------------
SELECT e.FullName, e.Position, m.FullName 'ManagerName', m.Position 'ManagerPosition'
FROM Employee e
INNER JOIN Employee m
ON e.ManagerId = m.Id
--------------------------
SELECT e.FullName, e.Position, m.FullName 'ManagerName', m.Position 'ManagerPosition'
FROM Employee e
LEFT OUTER JOIN Employee m
ON e.ManagerId = m.Id
--------------------------
SELECT e.FullName, e.Position, m.FullName 'ManagerName', m.Position 'ManagerPosition'
FROM Employee e
FULL OUTER JOIN Employee m
ON e.ManagerId = m.Id
-------------------------
SELECT  e1.FullName, e2.FullName
FROM Employee e1
CROSS JOIN Employee e2
WHERE e1.Id != e2.Id
--------------------------
SELECT GETDATE(), SYSDATETIME(), SYSDATETIMEOFFSET()
--------------------------
SELECT DATEPART(YEAR, GETDATE()),
DATEPART(MONTH, GETDATE()),
DATEPART(DAY, GETDATE()),
DATEPART(HOUR, GETDATE()),
DATEPART(MINUTE, GETDATE()),
DATEPART(SECOND, GETDATE())
--------------------------
USE AdventureWorks2016CTP3
--------------------------
SELECT hr.BusinessEntityId, p.FirstName, p.LastName, hr.JobTitle,
DATEPART(YEAR, GETDATE()) - DATEPART(YEAR, hr.BirthDate) 'Age',
DATEPART(YEAR, GETDATE()) - DATEPART(YEAR, hr.HireDate) 'Experience'
FROM HumanResources.Employee hr
INNER JOIN Person.Person p
ON hr.BusinessEntityID = p.BusinessEntityID

ORDER BY [Experience] DESC, [Age] DESC
--------------------------
SELECT hr.BusinessEntityId, p.FirstName, p.LastName, hr.JobTitle,
YEAR(GETDATE()) - YEAR(hr.BirthDate) 'Age',
YEAR(GETDATE()) - YEAR(hr.HireDate) 'Experience'
FROM HumanResources.Employee hr
INNER JOIN Person.Person p
ON hr.BusinessEntityID = p.BusinessEntityID

ORDER BY [Experience] DESC, [Age] DESC
---------------------------
SELECT DATEADD(MONTH, -2, GETDATE())
SELECT DATEADD(MINUTE, 5, GETDATE())
SELECT DATEADD(MONTH, 6, DATEADD(YEAR, 2, GETDATE()))
SELECT JobTitle,DATEADD(MONTH, 6, DATEADD(YEAR, 2, BirthDate))
FROM HumanResources.Employee
----------------------------
SELECT DATEADD(YEAR, 2, '2010-10-10 10:52:36' )
----------------------------
SELECT hr.BusinessEntityId, p.FirstName, p.LastName, hr.JobTitle,
DATEDIFF(YEAR, hr.BirthDate, GETDATE()) 'Age',
DATEDIFF(YEAR, hr.HireDate, GETDATE()) 'Experience'
FROM HumanResources.Employee hr
INNER JOIN Person.Person p
ON hr.BusinessEntityID = p.BusinessEntityID

ORDER BY [Experience] DESC, [Age] DESC
-----------------------------
SELECT SWITCHOFFSET(SYSDATETIMEOFFSET(), '+05:30')
-----------------------------
SELECT TODATETIMEOFFSET(GETDATE(), '+04:30')

