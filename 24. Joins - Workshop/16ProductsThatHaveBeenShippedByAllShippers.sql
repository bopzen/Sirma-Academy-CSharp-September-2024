SELECT 
	P.ProductName
FROM 
	Products P
JOIN OrderDetails OD ON P.ProductID = OD.ProductID
JOIN Orders O ON OD.OrderID = O.OrderID
JOIN Shippers S ON O.ShipperID = S.ShipperID
GROUP BY P.ProductName
HAVING COUNT(DISTINCT S.ShipperID) = (SELECT COUNT(*) FROM Shippers);