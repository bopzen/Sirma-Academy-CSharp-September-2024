CREATE PROCEDURE GetEmployeeAndDepartmentInfo 
AS
BEGIN
	SELECT * FROM Employees
	SELECT * FROM Departments
END;

EXEC GetEmployeeAndDepartmentInfo;