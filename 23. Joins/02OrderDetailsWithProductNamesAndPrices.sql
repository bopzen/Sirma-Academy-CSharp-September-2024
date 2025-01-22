SELECT
	O.OrderID,
	P.ProductName,
	OD.Quantity,
	P.Price
FROM
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P on P.ProductID = OD.ProductID