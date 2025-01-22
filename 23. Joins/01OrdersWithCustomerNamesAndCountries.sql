SELECT 
	O.OrderID,
	O.OrderDate,
	C.CustomerName,
	C.Country
FROM 
	Orders O
JOIN Customers C on C.CustomerID = O.CustomerID
