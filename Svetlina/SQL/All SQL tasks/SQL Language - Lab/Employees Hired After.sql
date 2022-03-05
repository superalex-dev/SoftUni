SELECT e.FirstName, e.LastName, e.HireDate, d.name
FROM employees e
JOIN departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate > '1999-01-01' AND d.name IN ('Sales', 'Finance')
ORDER BY e.HireDate ASC