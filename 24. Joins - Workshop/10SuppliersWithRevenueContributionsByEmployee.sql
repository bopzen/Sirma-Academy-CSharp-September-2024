SELECT
	S.SupplierName,
	E.FirstName + ' ' + E.LastName AS EmployeeName,
	SUM(OD.Quantity * P.Price) AS TotalRevenue
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
GROUP BY S.SupplierName, E.FirstName + ' ' + E.LastName
ORDER BY S.SupplierName