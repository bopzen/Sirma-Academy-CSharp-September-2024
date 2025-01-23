SELECT 
	O.OrderID,
	O.OrderDate,
	C.CustomerName,
	P.ProductName, 
	S.SupplierName
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
JOIN Customers C ON C.CustomerID = O.CustomerID
WHERE S.SupplierName = 'Leka Trading'