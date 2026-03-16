CREATE TABLE Department
(
DeptId INT,
DeptName VARCHAR(50)
);

CREATE TABLE Employees
(
EmpId INT,
Name VARCHAR(50),
Salary INT,
DeptId INT
);

INSERT INTO Department VALUES (1,'HR');
INSERT INTO Department VALUES (2,'IT');
INSERT INTO Department VALUES (3,'Sales');

INSERT INTO Employees VALUES (1,'Amit',60000,1);
INSERT INTO Employees VALUES (2,'Rahul',80000,2);
INSERT INTO Employees VALUES (3,'Priya',75000,2);
INSERT INTO Employees VALUES (4,'Karan',90000,3);
INSERT INTO Employees VALUES (5,'Sneha',65000,3);
INSERT INTO Employees VALUES (6,'Rohit',72000,3);

SELECT d.DeptName,
e.Name AS EmployeeName,
e.Salary AS HighestSalary
FROM Employees e
JOIN Department d ON e.DeptId = d.DeptId
WHERE e.Salary =
(
SELECT MAX(Salary)
FROM Employees
WHERE DeptId = e.DeptId
)
AND e.DeptId IN
(
SELECT DeptId
FROM Employees
GROUP BY DeptId
HAVING AVG(Salary) > 70000
);