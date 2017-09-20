CREATE DATABASE Session10
GO
USE Session10
GO
CREATE TABLE Account
(
	Id INT PRIMARY KEY,
	Balance INT
)
GO
ALTER DATABASE Session10
SET MULTI_USER
GO
USE master
GO
RESTORE DATABASE Session10
FROM DISK = 'C:\Backups\Session10.bak'
WITH RECOVERY, REPLACE
GO
RESTORE DATABASE Session10
FROM DISK = 'C:\Backups\Session10.bak'
WITH NORECOVERY, REPLACE
GO
RESTORE DATABASE Session10
FROM DISK = 'C:\Backups\Session10-Tail.bak'
WITH RECOVERY
GO
USE master
GO
ALTER DATABASE Session10
SET MULTI_USER
GO
EXEC sp_who
GO
KILL 56
GO
BACKUP DATABASE Session10
TO DISK = 'C:\Backups\Full-Session10.bak'