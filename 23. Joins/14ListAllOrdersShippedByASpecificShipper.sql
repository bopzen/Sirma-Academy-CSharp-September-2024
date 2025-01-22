SELECT
	O.OrderID,
	O.OrderDate,
	C.CustomerName,
	S.ShipperName
FROM 
	Orders O
JOIN Customers C on C.CustomerID = O.CustomerID
JOIN Shippers S on S.ShipperID = O.ShipperID
WHERE ShipperName = 'Federal Shipping'