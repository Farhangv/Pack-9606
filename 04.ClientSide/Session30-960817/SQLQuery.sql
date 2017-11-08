CREATE DATABASE TodoDb
Go
USE TodoDb
GO
CREATE TABLE Todo
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(100),
	DueDate NVARCHAR(10)
)