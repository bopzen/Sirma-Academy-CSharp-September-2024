BEGIN TRANSACTION

	UPDATE Products
	SET Stock = Stock + 50
	WHERE ProductID = 1;

	SAVE TRANSACTION SavePoint1;

	UPDATE Products
	SET Stock = Stock - 60
	WHERE ProductID = 2;

	IF (SELECT Stock FROM Products WHERE ProductID = 2) < 0
	BEGIN
		ROLLBACK TRANSACTION SavePoint1;
		PRINT 'Second update failed. Rolled back to first update';
		COMMIT TRANSACTION;
	END;
	ELSE
	BEGIN
		COMMIT TRANSACTION;
		PRINT 'Stock updated successfully';
	END;

