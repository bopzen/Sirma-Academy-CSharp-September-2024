SELECT
	E.Id,
	E.Name,
	E.JobTitle,
	E.Email,
	D.Name as [Department]
FROM Employees E
JOIN EmployeesProjects EP ON EP.EmployeeId = E.Id
JOIN Projects P on P.Id = EP.ProjectId
JOIN Departments D on D.Id = E.DepartmentId
WHERE P.Name = 'Project Delta';

SELECT DISTINCT 
	P.Name
FROM Projects P
JOIN EmployeesProjects EP ON EP.ProjectId = P.Id
JOIN Employees E on E.Id = EP.EmployeeId
JOIN Departments D on D.Id = E.DepartmentId
WHERE D.Name = 'IT';

SELECT
	D.Name as [Department Name],
	E.Name as [Employee Name]
FROM Departments D
JOIN Employees E on E.DepartmentId = D.Id;