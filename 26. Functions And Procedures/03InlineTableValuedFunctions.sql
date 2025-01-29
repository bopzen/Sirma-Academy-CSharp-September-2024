CREATE FUNCTION GetEmployeesByDepartment(@Id INT) 
RETURNS TABLE
AS
RETURN (
	SELECT 
		EmployeeId,
		Name,
		DepartmentId,
		Salary
	FROM
		Employees
	WHERE DepartmentId = @Id
);

SELECT * FROM dbo.GetEmployeesByDepartment(1);

CREATE FUNCTION GetProductsByCategory(@Id INT)
RETURNS TABLE
AS
RETURN (
	SELECT
		*
	FROM
		Products
	WHERE CategoryId = @Id
);

SELECT * FROM dbo.GetProductsByCategory(1);

CREATE FUNCTION GetAffordableProducts(@MaxPrice DECIMAL)
RETURNS TABLE
AS
RETURN (
	SELECT
		ProductId,
		ProductName,
		Price
	FROM
		Products
	WHERE Price < @MaxPrice
);

SELECT * FROM dbo.GetAffordableProducts(100);

CREATE FUNCTION GetDepartmentsWithEmployees()
RETURNS TABLE
AS
RETURN (
	SELECT
		DepartmentId,
		DepartmentName
	FROM
		Departments
	WHERE DepartmentId IN (SELECT DISTINCT DepartmentId FROM Employees)
);

SELECT * FROM dbo.GetDepartmentsWithEmployees();