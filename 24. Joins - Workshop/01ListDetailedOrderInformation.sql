SELECT 
	O.OrderID,
	C.CustomerName, 
	E.FirstName + ' ' + E.LastName AS EmployeeName,
	S.ShipperName,
	TotalPrice
FROM Orders O
JOIN 
	(SELECT 
		OD.OrderID,
		SUM(OD.Quantity * P.Price) as TotalPrice
	FROM
		OrderDetails OD
	JOIN Products P ON P.ProductID = OD.ProductID
	GROUP BY OD.OrderID
	) Totals
	ON Totals.OrderID = O.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
JOIN Shippers S ON S.ShipperID = O.ShipperID