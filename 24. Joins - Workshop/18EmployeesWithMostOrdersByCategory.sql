SELECT
	E.FirstName + ' ' + E.LastName AS EmployeeName,
	C.CategoryName, 
	SUM(OD.Quantity * P.Price) AS TotalRevenue
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID	
JOIN Employees E ON E.EmployeeID = O.EmployeeID
GROUP BY E.FirstName + ' ' + E.LastName, C.CategoryName
ORDER BY EmployeeName