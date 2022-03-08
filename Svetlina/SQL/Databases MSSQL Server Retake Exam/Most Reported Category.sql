SELECT TOP(5) c.Name AS CategoryName, COUNT(c.Id) AS ReportNumber 
FROM Categories AS c
JOIN Reports AS r ON r.CategoryId = c.Id
GROUP BY c.Name
ORDER BY COUNT(c.Id) DESC, c.Name