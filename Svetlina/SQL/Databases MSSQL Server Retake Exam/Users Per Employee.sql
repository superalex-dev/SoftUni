SELECT CONCAT_WS(' ', E.FirstName, E.LastName) AS FullName, COUNT(DISTINCT(R.UserId)) AS UserCount
FROM Employees AS E
LEFT JOIN Reports AS R ON E.Id = R.EmployeeId
GROUP BY E.Id
ORDER BY UserCount DESC, FullName