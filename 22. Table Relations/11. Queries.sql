SELECT 
	CONCAT(E.FirstName, ' ', E.LastName) AS [Full Name],
	E.JobTitle,
	E.Salary
FROM Employees E

SELECT 
	CONCAT(E.FirstName, ' ', E.LastName) AS [Full Name],
	D.DepartmentName
FROM Employees E
JOIN Departments D ON D.DepartmentID = E.DepartmentID

SELECT 
	CONCAT(E.FirstName, ' ', E.LastName) AS [Full Name],
	E.JobTitle
FROM Employees E
JOIN OfficeLocations OL ON OL.LocationID = E.LocationID
WHERE OL.LocationName = 'UK Branch'

SELECT
	CONCAT(E.FirstName, ' ', E.LastName) as [Full Name],
	E.JobTitle,
	E.Salary
FROM Employees E
WHERE E.Salary = (SELECT MAX(Salary) FROM Employees)

SELECT 
	D.DepartmentName,
	AVG(E.Salary) AS [Average Salary]
FROM Employees E
JOIN Departments D ON D.DepartmentID = E.DepartmentID
GROUP BY D.DepartmentName

SELECT 
	CONCAT(E.FirstName, ' ', E.LastName) as [Full Name],
	E.JobTitle
FROM Employees E
WHERE E.EmployeeID NOT IN (SELECT ManagerID FROM Departments)

SELECT 
	D.DepartmentName,
	CONCAT(E.FirstName, ' ', E.LastName) as [Manager Name]
FROM Departments D
JOIN Employees E on E.EmployeeID = D.ManagerID

SELECT 
	CONCAT(E.FirstName, ' ', E.LastName) as [Manager Name],
	C.CountryName
FROM Employees E
JOIN OfficeLocations OL on OL.LocationID = E.LocationID
JOIN Countries C on C.CountryID = OL.CountryID
WHERE C.CountryName = 'Bulgaria'

SELECT 
	C.CountryName,
	SUM(E.Salary) AS [Total Salary]
FROM Employees E
JOIN OfficeLocations OL on OL.LocationID = E.LocationID
JOIN Countries C on C.CountryID = OL.CountryID
GROUP BY C.CountryName

SELECT 
	CONCAT(E.FirstName, ' ', E.LastName) as [Manager Name],
	E.Salary
FROM Employees E
WHERE E.Salary > (SELECT AVG(Salary) FROM Employees)
