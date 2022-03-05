SELECT TOP 5 EmployeeID, FirstName, Salary, Name
From Employees AS e
JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE Salary > '15000'
ORDER BY d.[DepartmentID] asc