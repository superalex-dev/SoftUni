SELECT e.FirstName + ' ' + e.LastName AS FullName, COUNT(DISTINCT UserId) AS UserCount  FROM Reports AS r
RIGHT JOIN Employees AS e ON e.Id = r.EmployeeId
GROUP BY e.FirstName, e.LastName
ORDER BY COUNT(Distinct UserId) DESC, FullName