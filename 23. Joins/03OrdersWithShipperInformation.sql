SELECT 
	O.OrderID,
	O.OrderDate,
	S.ShipperName
FROM
	Orders O
JOIN Shippers S on S.ShipperID = O.ShipperID