SELECT
	S.SupplierName,
	P.ProductName
FROM
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE CustomerName = 'Wilman Kala'