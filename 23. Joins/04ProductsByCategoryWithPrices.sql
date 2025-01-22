SELECT 
	P.ProductName,
	C.CategoryName,
	P.Price
FROM
	Products P
JOIN Categories C on C.CategoryID = P.CategoryID