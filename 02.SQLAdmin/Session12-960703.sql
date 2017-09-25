CREATE DATABASE Session12
GO
USE Session12
GO
CREATE TABLE Customer
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	Family NVARCHAR(50),
	Phone NVARCHAR(15),
	SalesPersonUser NVARCHAR(50)
)
GO
CREATE PROC USP_Customer_Insert
(
	@Name NVARCHAR(50),
	@Family NVARCHAR(50),
	@Phone NVARCHAR(15)
)
AS
BEGIN
	INSERT INTO Customer(Name, Family, Phone, SalesPersonUser)
	VALUES (@Name, @Family, @Phone, USER_NAME())
END
GO
EXEC USP_Customer_Insert N'????', N'?????', '12345678'
GO
ALTER FUNCTION fn_securitypredicateCustomer
(
	@UserColumnName SYSNAME
)
RETURNS TABLE
WITH SCHEMABINDING
AS
RETURN 
SELECT 1 AS [fn_securitypredicateCustomer_result]
FROM dbo.Customer
WHERE @UserColumnName = USER_NAME() OR USER_NAME() = 'dbo'
GO
CREATE SECURITY POLICY CustomerRowFilter  
ADD FILTER PREDICATE 
dbo.fn_securitypredicateCustomer([SalesPersonUser])   
ON dbo.Customer  
GO
SELECT * FROM Customer
GO
SELECT Name, SalesPersonUser, 1 AS [fn_securitypredicateCustomer_result]
FROM dbo.Customer
WHERE SalesPersonUser = 'john'
GO

