SELECT
	E.EmployeeID,
	E.FirstName + ' ' + E.LastName AS EmployeeName
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderId
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
GROUP BY E.EmployeeID, E.FirstName + ' ' + E.LastName
HAVING COUNT(DISTINCT P.CategoryID) > 2