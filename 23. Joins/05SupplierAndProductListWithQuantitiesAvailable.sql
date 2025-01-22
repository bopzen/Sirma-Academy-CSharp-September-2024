SELECT 
	S.SupplierName,
	P.ProductName,
	P.Price
FROM
	Suppliers S
JOIN Products P on P.SupplierID = S.SupplierID