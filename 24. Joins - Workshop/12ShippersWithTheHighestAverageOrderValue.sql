SELECT
	S.ShipperName,
	SUM(OD.Quantity * P.Price) / COUNT(DISTINCT O.OrderID) AS AverageValue
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Shippers S ON S.ShipperID = O.ShipperID
GROUP BY S.ShipperName
ORDER BY 
	AverageValue DESC