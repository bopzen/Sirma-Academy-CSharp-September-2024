CREATE TRIGGER trg_instead_delete
ON Employees2
INSTEAD OF DELETE
AS
BEGIN
	INSERT INTO DeletedEmployees (EmployeeID, Name, Position, DeletedDate)
	SELECT EmployeeID, Name, Position, GETDATE() FROM deleted
	PRINT 'Employee added to DeletedEmployees table';
END;

DELETE FROM Employees2 WHERE EmployeeID = 1;
