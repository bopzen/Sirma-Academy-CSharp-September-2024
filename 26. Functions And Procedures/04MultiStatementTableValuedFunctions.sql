CREATE FUNCTION GetTopPaidEmployees(@Id INT)
RETURNS @TopEmployees TABLE
(
	EmployeeId INT,
	Name NVARCHAR(50),
	Salary DECIMAL(10,2)
)
AS
BEGIN
	INSERT INTO @TopEmployees(EmployeeId, Name, Salary)
	SELECT TOP 3
		EmployeeId,
		Name,
		Salary
	FROM
		Employees
	WHERE DepartmentId = @Id
	ORDER BY Salary DESC;

	RETURN;
END;

SELECT * FROM dbo.GetTopPaidEmployees(3);


CREATE FUNCTION GetEmployeeDetails()
RETURNS @EmployeesDetails TABLE
(
	EmployeeName NVARCHAR(50),
	Department NVARCHAR(50),
	Salary DECIMAL(10,2)
)
AS
BEGIN
	INSERT INTO @EmployeesDetails (EmployeeName, Department, Salary)
	SELECT
		e.Name,
		d.DepartmentName,
		e.Salary
	FROM Employees e
	JOIN Departments d ON d.DepartmentId = e.DepartmentId

	RETURN;
END;

SELECT * FROM GetEmployeeDetails();


CREATE FUNCTION GetOutOfStockProducts()
RETURNS @OutOfStockProducts TABLE
(
	ProductName NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO @OutOfStockProducts(ProductName)
	SELECT 
		ProductName
	FROM
		Products
	WHERE Stock = 0;

	RETURN;
END;

SELECT * FROM GetOutOfStockProducts();


CREATE FUNCTION GetEmployeesByAgeRange(@MinAge INT, @MaxAge INT)
RETURNS @EmployeesByAgeFiltered TABLE
(
	EmployeeName NVARCHAR(50),
	Age INT
)
AS
BEGIN
	INSERT INTO @EmployeesByAgeFiltered(EmployeeName, Age)
	SELECT 
		Name,
		YEAR(GETDATE()) - YEAR(DateOfBirth) AS EmployeeAge
	FROM
		Employees
	WHERE YEAR(GETDATE()) - YEAR(DateOfBirth) >= @MinAge
		AND YEAR(GETDATE()) - YEAR(DateOfBirth) <= @MaxAge

	RETURN;
END;

SELECT * FROM dbo.GetEmployeesByAgeRange(30, 40);