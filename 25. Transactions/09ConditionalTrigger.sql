CREATE TRIGGER trg_after_insert
ON Orders
AFTER INSERT
AS
BEGIN
	INSERT INTO HighValueOrders (OrderID, CustomerID, TotalAmount, RecordedDate)
    SELECT 
        OrderID, 
        CustomerID, 
        TotalAmount, 
        GETDATE()
    FROM INSERTED
    WHERE TotalAmount > 1000;

    PRINT 'High-value orders have been logged into the HighValueOrders table.';
END;

INSERT INTO Orders (OrderID, CustomerID, TotalAmount)
VALUES
    (1, 101, 800.00),
    (2, 102, 1200.50),
    (3, 103, 1500.00); 