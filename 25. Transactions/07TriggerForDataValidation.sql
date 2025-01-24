CREATE TRIGGER trg_data_validation
ON Products
INSTEAD OF INSERT
AS
BEGIN
	IF EXISTS (
		SELECT 1 FROM inserted WHERE Price < 0
	)
	BEGIN
		THROW 50001, 'Cannot insert negative price', 1;	
	END;

	INSERT INTO Products (ProductID, ProductName, Stock, Price)
    SELECT ProductID, ProductName, Stock, Price
    FROM inserted;
END;

INSERT INTO Products (ProductID, ProductName, Stock, Price)
VALUES (6, 'Mouse', 20,-50);