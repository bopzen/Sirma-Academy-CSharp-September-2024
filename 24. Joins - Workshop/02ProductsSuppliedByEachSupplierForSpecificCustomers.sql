SELECT
	S.SupplierName,
	P.ProductName,
	C.CustomerName,
	SUM(OD.Quantity) AS TotalQuantity
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY S.SupplierName, P.ProductName, C.CustomerName