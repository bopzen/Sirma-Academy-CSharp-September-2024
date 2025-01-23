SELECT
	C.CustomerName,
	S.ShipperName,
	SUM(OD.Quantity * P.Price) AS TotalRevenue
FROM
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Shippers S ON S.ShipperID = O.ShipperID
GROUP BY C.CustomerName, S.ShipperName
ORDER BY C.CustomerName