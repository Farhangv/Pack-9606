USE AdventureWorks2016CTP3
GO
CREATE FUNCTION UDF_SearchEmployees
(
	@SearchPhrase NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN
SELECT * FROM Person.Person
WHERE (PersonType = 'EM' ) AND
	(
	 FirstName LIKE '%' + @SearchPhrase + '%' OR 
	 MiddleName LIKE '%' + @SearchPhrase + '%' OR	
	 LastName LIKE '%' + @SearchPhrase + '%'
	 )
GO
SELECT *
FROM UDF_SearchEmployees('john')
GO
ALTER FUNCTION UDF_SearchCustomers
(
	@SearchPhrase NVARCHAR(50),
	@PageNumber INT,
	@RecordsPerPage INT
)
RETURNS @Result TABLE
(
	[Row] INT,
	[BusinessEntityID] [int],
	[PersonType] [nchar](2),
	[NameStyle] [dbo].[NameStyle],
	[Title] [nvarchar](8),
	[FirstName] [dbo].[Name],
	[MiddleName] [dbo].[Name] ,
	[LastName] [dbo].[Name],
	[Suffix] [nvarchar](10),
	[EmailPromotion] [int],
	[AdditionalContactInfo] [xml],
	[Demographics] [xml],
	[rowguid] [uniqueidentifier],
	[ModifiedDate] [datetime]
)
AS
BEGIN
	INSERT INTO @Result
	SELECT *
	FROM(
		SELECT ROW_NUMBER() OVER (ORDER BY FirstName) 'Row',* FROM Person.Person
		WHERE (PersonType = 'SC' ) AND
		(
		 FirstName LIKE '%' + @SearchPhrase + '%' OR 
		 MiddleName LIKE '%' + @SearchPhrase + '%' OR	
		 LastName LIKE '%' + @SearchPhrase + '%'
		 )
	 ) AS t
	 WHERE [Row] BETWEEN ((@PageNumber - 1) * @RecordsPerPage) + 1 AND @PageNumber * @RecordsPerPage
	 RETURN
END

GO
SELECT *
FROM UDF_SearchCustomers('John', 2,5)
GO
CREATE DATABASE Session08
GO
USE Session08
GO
SELECT *
INTO CustomersPage2
FROM AdventureWorks2016CTP3.dbo.UDF_SearchCustomers('John', 2,5)
GO
CREATE TABLE [User]
(
	Id INT PRIMARY KEY IDENTITY,
	[Username] NVARCHAR(50) UNIQUE,
	[PasswordHash] NVARCHAR(100),
	[Email] NVARCHAR(100) UNIQUE
)
GO
INSERT INTO [User] VALUES ('John', '123', 'john@doe.com')
GO
CREATE PROC USP_User_Insert
(
	@Username NVARCHAR(50),
	@Password NVARCHAR(50),
	@Email NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO [User] VALUES (@Username, 
	HASHBYTES('MD5', @Password), 
	@Email)
END
GO
EXEC USP_User_Insert 'Sarah','123', 'sarah@smith.com'
GO
SELECT * FROM [User]
GO
SELECT * FROM [User]
--USP_User_Insert 'jane','123', 'jane@smith.com'
GO
ALTER PROC USP_User_SelectById
(
	@Id INT 
)
AS
BEGIN
	SELECT * FROM [User] WHERE Id = @Id
	SELECT GETDATE()
	SELECT SYSDATETIME()
	SELECT @@CONNECTIONS
END
GO
EXEC USP_User_SelectById 2
GO
DECLARE @Result INT
EXEC @Result = USP_User_SelectById 2
SELECT @Result
GO
ALTER PROC USP_User_SelectById
(
	@Id INT 
)
AS
BEGIN
	SELECT * FROM [User] WHERE Id = @Id
	RETURN 1
END
GO
DECLARE @Result INT
EXEC @Result = USP_User_SelectById 2
SELECT @Result

GO
CREATE PROC USP_User_Authenticate
(
	@Username NVARCHAR(50),
	@Password NVARCHAR(50)
)
AS
BEGIN
	IF EXISTS(SELECT * FROM [User] 
	WHERE Username = @Username AND
	PasswordHash = HASHBYTES('MD5', @Password))
	BEGIN
		RETURN 1
	END
	ELSE
	BEGIN
		RETURN 0
	END
END
GO
DECLARE @IsAuthenticated BIT
EXEC @IsAuthenticated = USP_User_Authenticate 'David' , '1234'
SELECT @IsAuthenticated
GO
CREATE PROC USP_User_TryInsert
(
	@Username NVARCHAR(50),
	@Password NVARCHAR(50),
	@Email NVARCHAR(50)

)
AS
BEGIN
	BEGIN TRY
		INSERT INTO [User] VALUES (@Username, 
		HASHBYTES('MD5', @Password), 
		@Email)
		RETURN 0
	END TRY
	BEGIN CATCH
		RETURN ERROR_NUMBER()
	END CATCH

END
GO
DECLARE @R INT
EXEC @R = USP_User_TryInsert 'Johnnny' , '123', 'J@Dddd.com'
IF(@R = 0)
BEGIN
	PRINT N'رکورد با موفقیت ثبت شد'
END
ELSE
BEGIN
	PRINT N'خطایی با کد زیر هنگام درج کاربر اتفاق افتاد'
	PRINT @R
END
GO
ALTER PROC USP_User_TryInsert
(
	@Username NVARCHAR(50),
	@Password NVARCHAR(50),
	@Email NVARCHAR(50),
	@ErrorMessage NVARCHAR(200) OUTPUT
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO [User] VALUES (@Username, 
		HASHBYTES('MD5', @Password), 
		@Email)
		RETURN 0
	END TRY
	BEGIN CATCH
		SELECT @ErrorMessage = ERROR_MESSAGE()
		RETURN ERROR_NUMBER()
	END CATCH

END
GO
DECLARE @R INT
DECLARE @Message NVARCHAR(200)
EXEC @R = USP_User_TryInsert 'Johnnny' , '123', 'J@Dddd.com', @Message OUTPUT
IF(@R = 0)
BEGIN
	PRINT N'رکورد با موفقیت ثبت شد'
END
ELSE
BEGIN
	PRINT N'خطایی با کد زیر هنگام درج کاربر اتفاق افتاد'
	PRINT @R
	PRINT @Message
END
