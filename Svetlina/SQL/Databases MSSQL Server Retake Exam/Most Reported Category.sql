SELECT Name AS CategoryName, COUNT(*) AS ReportsNumber
FROM Categories AS C
JOIN Reports AS R ON C.Id = R.CategoryId
GROUP BY R.CategoryId
ORDER BY ReportsNumber, Name