BEGIN TRY
	BEGIN TRANSACTION

	UPDATE Products
	SET Stock = Stock - 50
	WHERE ProductID = 1;

	UPDATE Products
	SET Stock = Stock - 50
	WHERE ProductID = 2;

	UPDATE Products
	SET Stock = Stock - 50
	WHERE ProductID = 3;

	IF EXISTS (
		SELECT 1 
		FROM
			Products
		WHERE Stock < 0
	)
	BEGIN
		THROW 50000, 'Stock cannot be negative', 1;
	END;

	COMMIT TRANSACTION;
	PRINT 'Stock updated successfully';
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION;
	PRINT ERROR_MESSAGE();
END CATCH;