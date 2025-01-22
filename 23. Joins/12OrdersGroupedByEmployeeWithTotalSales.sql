SELECT
	E.FirstName + ' ' + E.LastName AS EmployeeName,
	SUM(OD.Quantity * P.Price) AS TotalSales
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P on P.ProductID = OD.ProductID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
GROUP BY
	E.FirstName + ' ' + E.LastName