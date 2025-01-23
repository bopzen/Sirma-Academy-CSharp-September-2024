SELECT 
	C.CategoryName,
	S.SupplierName,
	SUM(OD.Quantity * P.Price) AS TotalPrice
FROM
	OrderDetails OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
GROUP BY C.CategoryName, S.SupplierName