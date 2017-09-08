USE Session05
---------------------
CREATE TABLE Score
(
	Id INT PRIMARY KEY IDENTITY,
	StudentId INT,
	CourseId INT,
	SemesterId INT,
	Score DECIMAL(4,2),
	--CONSTRAINT PK_Score PRIMARY KEY(StudentId, CourseId, SemesterId)
	--UNIQUE(StudentId, CourseId, SemesterId)
	CONSTRAINT UQ_Score UNIQUE(StudentId, CourseId, SemesterId)
)
----------------------
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
	Email NVARCHAR(50) UNIQUE NOT NULL CHECK(Email LIKE '%@%.%'),
	CellPhone CHAR(11) CHECK(CellPhone LIKE '09_________'),
	CreatedDate DATETIME DEFAULT GETDATE(),
	CONSTRAINT PK_Student_Id PRIMARY KEY(Id)
)
----------------------
CREATE TABLE Course
(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(50),
	Duration INT
)
-----------------------
CREATE TABLE Teacher
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50)
)
-----------------------
CREATE TABLE [User]
(
	Id INT PRIMARY KEY IDENTITY,
	Username NVARCHAR(50),
	[Password] NVARCHAR(50),
	StudentId INT NOT NULL UNIQUE FOREIGN KEY REFERENCES Student(Id)
)
------------------------
DROP TABLE [user]
------------------------
CREATE TABLE [User]
(
	Id INT PRIMARY KEY FOREIGN KEY REFERENCES Student(Id),
	Username NVARCHAR(50),
	[Password] NVARCHAR(50)
)
------------------------
CREATE TABLE Course
(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(50),
	Duration INT,
	TeacherId INT,
	FOREIGN KEY(TeacherId) REFERENCES Teacher(Id)
)
-----------------------
CREATE TABLE Teacher
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50)
)
------------------------
CREATE TABLE Student_Course
(
	StudentId INT,
	CourseId INT,
	CONSTRAINT PK_StudentCourse PRIMARY KEY(StudentId,CourseId),
	CONSTRAINT FK_Student FOREIGN KEY (StudentId) REFERENCES Student(Id),
	CONSTRAINT FK_Course FOREIGN KEY (CourseId) REFERENCES Course(Id)
)
--------------------------
SELECT s.Name, s.Family, c.Title, t.FullName
FROM Student s
INNER JOIN Student_Course sc 
ON s.Id = sc.StudentId
INNER JOIN Course c
ON sc.CourseId = c.Id
INNER JOIN Teacher t
ON c.TeacherId = t.Id
---------------------------
CREATE DATABASE Session06
GO
USE Session06
GO
CREATE TABLE Teacher
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50)
)
GO
CREATE TABLE Course
(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(50),
	Duration INT,
	TeacherId INT,
	FOREIGN KEY(TeacherId) REFERENCES Teacher(Id)
)
GO
SELECT NEWID()
GO
DROP TABLE Course
GO
DROP TABLE Teacher
GO
CREATE TABLE Teacher
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50),
	[RowVersion] TIMESTAMP
)
GO
SELECT * FROM Teacher
GO
UPDATE Teacher SET FullName = 'David Smith'
WHERE Id = 1
