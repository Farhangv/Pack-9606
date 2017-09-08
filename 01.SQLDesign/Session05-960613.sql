USE Session04
----------------------
UPDATE Student
SET Name = N'جان',
Family = N'دو'
WHERE Id = 1
----------------------
SELECT * FROM Student
----------------------
UPDATE Student
SET Name = N'جان',
Family = N'دو'
--WHERE Id = 1
-----------------------
UPDATE Student
SET Name = N'جان',
Family = N'دو'
WHERE Family = N'اسمیت'
------------------------
DELETE FROM Product
WHERE ProductId = 1
------------------------
SELECT * FROM Product
------------------------
DELETE FROM Product
--WHERE ProductId = 1
-------------------------
SELECT *
INTO Sales1
FROM AdventureWorks2016CTP3.Sales.SalesOrderDetail
------------------
SELECT *
INTO Sales2
FROM AdventureWorks2016CTP3.Sales.SalesOrderDetail
-------------------
DELETE FROM Sales1
-------------------
TRUNCATE TABLE Sales2
-------------------
CREATE DATABASE Session05
-------------------
DROP DATABASE Session05
-------------------
USE AdventureWorks2016CTP3
-------------------
EXEC sp_detach_db 'Session04'
-------------------
EXEC sp_attach_db 'Session04', 
'D:\Session04.mdf', 
'D:\Session04_log.ldf'
-------------------
CREATE DATABASE Session05
ON -- MDF
(
	NAME = 'Session05_Data',
	FILENAME = 'D:\Session05_Data.mdf',
	SIZE = 10MB ,
	MAXSIZE = 50MB
)
LOG ON -- LDF
(
	NAME = 'Session05_Log',
	FILENAME = 'D:\Session05_Log.ldf',
	SIZE = 10MB ,
	MAXSIZE = 50MB
)
------------------
CREATE DATABASE Session052
------------------
USE Session05
------------------
CREATE TABLE Student
(
	Id INT,
	Name NVARCHAR(50),
	Family NVARCHAR(50),
	BirthDate DATE,
	Age INT,
	Average DECIMAL(4,2)
)
---------------------
DROP TABLE Student
---------------------
CREATE TABLE Student
(
	Id INT IDENTITY(1000,2), --PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Family NVARCHAR(50) NOT NULL,
	NationalCode CHAR(10) NOT NULL UNIQUE,
	BirthDate DATE,
	Age AS YEAR(GETDATE()) - YEAR(BirthDate),
	Average DECIMAL(4,2),
	--PRIMARY KEY(Id)
	CONSTRAINT PK_Student_Id PRIMARY KEY(Id)
)

---------------------------
USE AdventureWorks2016CTP3
---------------------------
SELECT Category,Product
FROM(
SELECT c.Name 'Category', p.Name 'Product',
DENSE_RANK() OVER(PARTITION BY c.Name ORDER BY SUM(s.OrderQty) DESC) 'Rank'
FROM Production.ProductCategory c 
INNER JOIN Production.ProductSubcategory sc
ON sc.ProductCategoryID = c.ProductCategoryID
INNER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID 
INNER JOIN Sales.SalesOrderDetail s
ON s.ProductID = p.ProductID
GROUP BY c.Name, p.Name
) AS t
WHERE [Rank] = 1

-----------------------------
