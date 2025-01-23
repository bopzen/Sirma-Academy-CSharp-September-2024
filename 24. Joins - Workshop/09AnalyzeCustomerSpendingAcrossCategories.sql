SELECT 
	C.CustomerName,
	CA.CategoryName,
	SUM(OD.Quantity) as TotalQuantity
FROM 
	Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories CA ON CA.CategoryID = P.CategoryID
GROUP BY C.CustomerName, CA.CategoryName
ORDER BY C.CustomerName