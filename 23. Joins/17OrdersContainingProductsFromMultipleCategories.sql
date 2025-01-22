SELECT 
	O.OrderID
FROM
	Orders O
JOIN OrderDetails OD on OD.OrderID = O.OrderID
JOIN Products P on P.ProductID = OD.ProductID
JOIN Categories C on C.CategoryID = P.CategoryID
GROUP BY O.OrderID
HAVING COUNT(DISTINCT C.CategoryID) > 1