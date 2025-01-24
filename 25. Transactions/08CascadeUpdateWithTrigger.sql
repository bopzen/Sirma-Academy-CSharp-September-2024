CREATE TRIGGER trg_after_upd
ON Departments
AFTER UPDATE
AS
BEGIN
	UPDATE Employees
	SET DepartmentName = D.DepartmentName
	FROM Employees E
	JOIN INSERTED D ON E.DepartmentID = D.DepartmentID;
END;


UPDATE Departments
SET DepartmentName = 'Human Resources'
WHERE DepartmentID = 1;