SELECT 
	S.ShipperName, 
	P.ProductName,
	SUM(OD.Quantity) as TotalQuantity
FROM
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN Shippers S ON S.ShipperID = O.ShipperID
WHERE C.CategoryName = 'Beverages'
GROUP BY S.ShipperName, P.ProductName
ORDER BY S.ShipperName