BEGIN TRANSACTION;

UPDATE Accounts 
SET Balance = Balance - 500
WHERE AccountID = 1

UPDATE Accounts
SET Balance = Balance + 500
WHERE AccountID = 2

IF (SELECT Balance FROM Accounts WHERE AccountID = 1) < 0
	BEGIN
		PRINT 'Insufficient funds';
		ROLLBACK TRANSACTION;
	END;
ELSE
	BEGIN
		PRINT 'Transfer successful';
		COMMIT TRANSACTION
	END;


