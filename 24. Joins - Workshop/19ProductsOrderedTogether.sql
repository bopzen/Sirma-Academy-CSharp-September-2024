SELECT 
    p1.ProductName AS ProductName1,
    p2.ProductName AS ProductName2,
    COUNT(*) AS TimesOrderedTogether
FROM OrderDetails od1
JOIN OrderDetails od2 ON od1.OrderID = od2.OrderID AND od1.ProductID < od2.ProductID
JOIN Products p1 ON od1.ProductID = p1.ProductID
JOIN Products p2 ON od2.ProductID = p2.ProductID
GROUP BY p1.ProductName, p2.ProductName
ORDER BY TimesOrderedTogether DESC;