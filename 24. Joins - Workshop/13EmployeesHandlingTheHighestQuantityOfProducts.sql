SELECT
	E.FirstName + ' ' + E.LastName AS EmployeeName,
	SUM(OD.Quantity) AS TotalQuantity
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
GROUP BY E.FirstName + ' ' + E.LastName
ORDER BY TotalQuantity DESC