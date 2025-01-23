SELECT
	P.ProductName,
	COUNT(DISTINCT C.CustomerID) AS Customers
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY P.ProductName
