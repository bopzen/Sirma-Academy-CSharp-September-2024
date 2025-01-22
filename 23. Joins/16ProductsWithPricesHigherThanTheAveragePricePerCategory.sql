SELECT
	P.ProductName,
	P.Price
FROM
	Products P
JOIN Categories C ON C.CategoryID = P.CategoryID
WHERE P.Price > (
	SELECT AVG(P2.Price)
	FROM Products P2
	WHERE P2.CategoryID = P.CategoryID	
	)
	