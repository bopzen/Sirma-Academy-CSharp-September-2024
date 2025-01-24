BEGIN TRANSACTION;

INSERT INTO Accounts (AccountID, AccountName, Balance)
VALUES (2, 'Ivan Ivanov', -100);

IF (SELECT Balance FROM Accounts WHERE AccountID = 2) < 0
BEGIN
	PRINT 'Balance is less than zero.';
	ROLLBACK TRANSACTION;
END
ELSE
BEGIN
	PRINT 'Balance added successfully.';
	COMMIT TRANSACTION;
END;