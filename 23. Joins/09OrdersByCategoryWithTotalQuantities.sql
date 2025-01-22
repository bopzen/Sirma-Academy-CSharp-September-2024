SELECT 
	O.OrderID,
	C.CategoryName,
	SUM(OD.Quantity) AS [TotalQuantity]
FROM
	Orders O
JOIN OrderDetails OD on OD.OrderID = O.OrderID
JOIN Products P on P.ProductID = OD.ProductID
JOIN Categories C on C.CategoryID = P.CategoryID
GROUP BY C.CategoryName, O.OrderID