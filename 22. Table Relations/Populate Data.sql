INSERT INTO Departments (Name, ManagerId)
VALUES 
('Human Resources', NULL), 
('IT', NULL),              
('Finance', NULL);

INSERT INTO Employees (Name, JobTitle, Email, DepartmentId)
VALUES
('Alice Johnson', 'HR Specialist', 'alice.johnson@example.com', 1),
('Bob Smith', 'IT Manager', 'bob.smith@example.com', 2),
('Charlie Davis', 'Software Developer', 'charlie.davis@example.com', 2),
('Diana White', 'Accountant', 'diana.white@example.com', 3),
('Evan Brown', 'Finance Manager', 'evan.brown@example.com', 3);

UPDATE Departments
SET ManagerId = 1
WHERE Id = 1

UPDATE Departments
SET ManagerId = 2
WHERE Id = 2

UPDATE Departments
SET ManagerId = 5
WHERE Id = 3

INSERT INTO Projects (Name, Description, Deadline)
VALUES
('Project Alpha', 'Develop new HR software', '2025-03-01'),
('Project Beta', 'Upgrade company network infrastructure', '2025-06-15'),
('Project Gamma', 'Implement cloud storage', '2025-09-01'),
('Project Delta', 'Prepare financial report for Q4', '2025-04-01'),
('Project Epsilon', 'Automate payroll processing', '2025-07-01');

INSERT INTO EmployeesProjects (EmployeeId, ProjectId)
VALUES
(1, 1),
(2, 2),
(3, 2),
(3, 3),
(4, 4),
(5, 4),
(5, 5);