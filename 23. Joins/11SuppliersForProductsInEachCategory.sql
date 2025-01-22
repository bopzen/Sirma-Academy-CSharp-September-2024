SELECT 
	C.CategoryName,
	S.SupplierName,
	P.ProductName
FROM
	Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
JOIN Suppliers S on S.SupplierID = P.SupplierID