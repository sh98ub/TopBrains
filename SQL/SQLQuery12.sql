CREATE TABLE Attendance
(
EmpId INT,
MonthName VARCHAR(10),
TotalPresent INT
);

INSERT INTO Attendance VALUES (1,'Jan',20);
INSERT INTO Attendance VALUES (1,'Feb',18);
INSERT INTO Attendance VALUES (1,'Mar',22);
INSERT INTO Attendance VALUES (2,'Jan',19);
INSERT INTO Attendance VALUES (2,'Feb',21);
INSERT INTO Attendance VALUES (2,'Mar',20);

SELECT *
FROM
(
SELECT EmpId, MonthName, TotalPresent
FROM Attendance
) AS SourceTable
PIVOT
(
SUM(TotalPresent)
FOR MonthName IN ([Jan],[Feb],[Mar],[Apr],[May],[Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])
) AS PivotTable;