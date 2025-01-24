CREATE TRIGGER trg_after_insert
ON Orders
AFTER INSERT
AS
BEGIN
	INSERT INTO OrderLog(OrderID, LogDate)
	SELECT OrderId, GETDATE() FROM inserted
	PRINT 'New orders have been logged into OrderLog.';
END;

INSERT INTO Orders (OrderID, CustomerID, OrderDate)
VALUES (1, 101, '2025-01-23'),
       (2, 102, '2025-01-23');