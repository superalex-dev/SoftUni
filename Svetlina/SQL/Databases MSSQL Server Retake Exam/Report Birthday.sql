SELECT u.Username, c.Name AS CategoryName FROM Reports AS r
JOIN Categories AS c ON c.Id = r.CategoryId
JOIN Users AS u ON u.Id = r.UserId
WHERE DATEPART(Day, u.Birthdate) = DATEPART(Day, r.OpenDate)
ORDER BY u.Username, c.Name