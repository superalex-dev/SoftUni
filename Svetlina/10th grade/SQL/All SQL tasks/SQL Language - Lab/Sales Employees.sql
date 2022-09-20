SELECT EmployeeID, FirstName, LastName, Name
From Employees AS e
JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE Name = 'sales'
ORDER BY EmployeeID asc