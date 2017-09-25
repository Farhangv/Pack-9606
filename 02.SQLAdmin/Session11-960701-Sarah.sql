USE Session11
GO
SELECT Id, Name, Quantity FROM Product
GO
UPDATE Product SET Name = 'Laptop' WHERE Id = 1
GO
UPDATE Product SET Quantity = 20 WHERE Id = 1
GO
