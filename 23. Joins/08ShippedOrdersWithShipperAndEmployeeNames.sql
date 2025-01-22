SELECT
	O.OrderID,
	O.OrderDate,
	S.ShipperName,
	E.FirstName + ' ' + E.LastName AS [Employee Name]
FROM
	Orders O
JOIN Employees E on E.EmployeeID = O.EmployeeID
JOIN Shippers S on S.ShipperID = O.ShipperID