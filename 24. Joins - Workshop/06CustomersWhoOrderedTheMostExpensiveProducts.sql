SELECT
	C.CustomerName, 
	O.OrderID, 
	P.ProductName
FROM
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE P.ProductID IN (
SELECT 
	ProductID
FROM
	Products
WHERE P.Price > (SELECT AVG(Price) FROM Products))