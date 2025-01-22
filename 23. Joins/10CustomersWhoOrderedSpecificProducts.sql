SELECT
	C.CustomerName,
	O.OrderId,
	P.ProductName
FROM 
	Orders O
JOIN OrderDetails OD on OD.OrderID = O.OrderID
JOIN Products P on P.ProductID = OD.ProductID
JOIN Customers C on C.CustomerID = O.CustomerID
WHERE P.ProductName = 'Tofu'