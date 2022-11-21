SELECT TOP(10) FirstName, LastName, e.DepartmentID
FROM Employees AS e
JOIN
(SELECT e.DepartmentID, avg(e.Salary) AS avgSalary
FROM Employees AS e
GROUP BY e.DepartmentID) AS avgSalaries ON e.DepartmentID = avgSalaries.DepartmentID
WHERE e.Salary > avgSalaries.avgSalary
ORDER BY e.DepartmentID