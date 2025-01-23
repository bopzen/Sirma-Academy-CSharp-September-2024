SELECT
	S.SupplierName,
	P.ProductName
FROM
	Products P
JOIN Suppliers S ON S.SupplierID = P.SupplierID
LEFT JOIN OrderDetails OD ON OD.ProductID = P.ProductID
WHERE OD.OrderID IS NULL