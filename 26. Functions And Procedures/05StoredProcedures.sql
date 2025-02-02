CREATE PROCEDURE UpdateSalary
	@EmployeeId INT,
	@Percentage INT
AS
BEGIN
	UPDATE Employees
	SET Salary = Salary + Salary * @Percentage / 100
	WHERE EmployeeId = @EmployeeId
END;

EXEC UpdateSalary 1, 10;


CREATE PROCEDURE AddNewProduct
	@ProductName NVARCHAR(50),
	@CategoryId INT,
	@Price DECIMAL(10,2),
	@Stock INT
AS
BEGIN
	INSERT INTO Products
	VALUES(@ProductName, @CategoryId, @Price, @Stock)
	PRINT 'Product added successfully'
END;

EXEC AddNewProduct 'Smartwatch', 1, 199.99, 100;


CREATE PROCEDURE DeleteLowStockProducts 
AS
BEGIN
	DELETE FROM Products
	WHERE Stock < 5;
END;

EXEC DeleteLowStockProducts;


CREATE PROCEDURE TransferEmployee 
	@EmployeeId INT,
	@DepartmentId INT
AS
BEGIN
	UPDATE Employees
	SET DepartmentId = @DepartmentId
	WHERE EmployeeId = @EmployeeId
END;

SELECT * FROM Employees

EXEC TransferEmployee 4, 2;