USE Session09
GO
CREATE TABLE Account
(
	ID INT IDENTITY PRIMARY KEY,
	Balance INT 
)
GO
INSERT INTO Account  VALUES(1000)
GO
UPDATE Account SET Balance = 2000 WHERE ID = 1
UPDATE Account SET Balance = 500 WHERE ID = 1
GO 10000
USE Session09Simple
GO
CREATE TABLE Account
(
	ID INT IDENTITY PRIMARY KEY,
	Balance INT 
)
GO
INSERT INTO Account  VALUES(1000)
GO
UPDATE Account SET Balance = 2000 WHERE ID = 1
UPDATE Account SET Balance = 500 WHERE ID = 1
GO 10000
UPDATE Account SET Balance = 6000
GO
INSERT INTO Account VALUES(20000)
GO
INSERT INTO Account VALUES(30000)
GO
INSERT INTO Account VALUES(40000)
GO
EXEC sp_configure 'show advanced option', '1'
RECONFIGURE
GO
EXEC sp_configure 'xp_cmdshell' , '1'
RECONFIGURE
GO
EXEC xp_cmdshell 'dir c:\'
GO
EXEC xp_cmdshell 'del d:\session09.bak'
