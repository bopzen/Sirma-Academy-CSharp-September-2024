SELECT
	O.OrderID,
	C.CustomerName, 
	E.FirstName + ' ' + E.LastName AS EmployeeName,
	Totals.CategoriesCount
FROM
	Orders O
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
JOIN 
	(
	SELECT
		O.OrderID,
		COUNT(DISTINCT P.CategoryID) AS CategoriesCount
	FROM 
		Orders O
	JOIN OrderDetails OD ON OD.OrderID = O.OrderID
	JOIN Products P ON P.ProductID = OD.ProductID
	JOIN Categories C ON C.CategoryID = P.CategoryID
	GROUP BY O.OrderID
	) Totals
	ON Totals.OrderID = O.OrderID
ORDER BY Totals.CategoriesCount DESC