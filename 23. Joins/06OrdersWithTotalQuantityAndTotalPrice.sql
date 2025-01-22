SELECT 
	O.OrderID,
	C.CustomerName,
	SUM(OD.Quantity) AS [Total Quantity],
	SUM(P.Price) AS [Total Price]
FROM
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY O.OrderID, C.CustomerName