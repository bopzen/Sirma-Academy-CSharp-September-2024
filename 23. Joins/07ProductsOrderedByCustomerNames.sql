SELECT
	C.CustomerName,
	P.ProductName,
	OD.Quantity
FROM Customers C
JOIN Orders O on O.CustomerID = C.CustomerID
JOIN OrderDetails OD on OD.OrderID = O.OrderID
JOIN Products P on P.ProductID = OD.ProductID