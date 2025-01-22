SELECT 
	C.CustomerName,
	E.FirstName + ' ' + E.LastName AS EmployeeName,
	O.OrderID
FROM
	Orders O 
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Employees E ON E.EmployeeID = O.EmployeeID