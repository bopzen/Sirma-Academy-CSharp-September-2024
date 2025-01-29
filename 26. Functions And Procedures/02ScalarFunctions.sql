CREATE FUNCTION GetFullYear(@Date DATE)
RETURNS INT
AS
BEGIN
	RETURN YEAR(@Date)
END;

SELECT dbo.GetFullYear(GETDATE());

CREATE FUNCTION GetAnnualSalary(@MonthlySalary DECIMAL)
RETURNS DECIMAL
AS
BEGIN
	RETURN @MonthlySalary * 12
END;

SELECT dbo.GetAnnualSalary(5000);

CREATE FUNCTION IsInStock(@Id INT)
RETURNS NVARCHAR(5)
AS
BEGIN
	DECLARE @Result NVARCHAR(5);
	IF EXISTS (
		SELECT 1 FROM Products
		WHERE ProductId = @Id AND Stock > 0
	)
		BEGIN
			SET @Result = 'TRUE';
		END
	ELSE
		BEGIN
			SET @Result = 'FALSE';
		END
	RETURN @Result;
END;

SELECT dbo.IsInStock(1);

CREATE FUNCTION GetDiscountPrice(@Price DECIMAL, @DiscountPercentage DECIMAL) 
RETURNS DECIMAL(10,2)
AS
BEGIN
	RETURN @Price - @Price * @DiscountPercentage / 100
END;

SELECT dbo.GetDiscountPrice(699.99, 10);