CREATE DATABASE TableRelations;

USE TableRelations;

CREATE TABLE Departments (
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50),
	ManagerId INT
);

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(100),
	JobTitle VARCHAR(50),
	Email VARCHAR(50) UNIQUE,
	DepartmentId INT,
	CONSTRAINT FK_Employees_Departments
	FOREIGN KEY (DepartmentId)
	REFERENCES Departments(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

ALTER TABLE Departments
	ADD CONSTRAINT FK_Departments_Employees
	FOREIGN KEY (ManagerId)
	REFERENCES Employees(Id);

CREATE TABLE Projects (
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50),
	Description VARCHAR(100),
	Deadline DATETIME
);

CREATE TABLE EmployeesProjects (
	EmployeeId INT,
	ProjectId INT,
	PRIMARY KEY (EmployeeId, ProjectId),
	CONSTRAINT FK_EmployeesProjects_Employees
	FOREIGN KEY (EmployeeId)
	REFERENCES Employees(Id),
	CONSTRAINT FK_EmployeesProjects_Projects
	FOREIGN KEY (ProjectId)
	REFERENCES Projects(Id)
);


