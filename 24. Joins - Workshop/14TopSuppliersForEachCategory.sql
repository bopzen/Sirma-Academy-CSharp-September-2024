SELECT
	C.CategoryName,
	S.SupplierName,
	SUM(OD.Quantity * P.Price) AS TotalRevenue
FROM 
	Orders O
JOIN OrderDetails OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
JOIN Categories C ON C.CategoryID = P.CategoryID
GROUP BY C.CategoryName, S.SupplierName
ORDER BY TotalRevenue DESC