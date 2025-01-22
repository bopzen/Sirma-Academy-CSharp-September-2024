SELECT
	C.CustomerName,
	O.OrderID,
	O.OrderDate
FROM
	Orders O
JOIN Customers C ON C.CustomerID = O.CustomerID
WHERE MONTH(O.OrderDate) = 11;
