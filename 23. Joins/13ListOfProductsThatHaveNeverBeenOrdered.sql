SELECT *
FROM
	Products P
LEFT JOIN OrderDetails OD on OD.ProductID = P.ProductID
WHERE OrderDetailID IS NULL