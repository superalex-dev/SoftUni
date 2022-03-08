SELECT DISTINCT C.Name AS CategoryName
FROM Reports AS R
JOIN Users AS U ON R.UserId = U.Id
JOIN Categories AS C ON R.CategoryId = C.Id
WHERE DAY(R.OpenDate) = DAY(U.[Birthdate]) 
AND MONTH(R.OpenDate) = MONTH(U.[Birthdate])
ORDER BY CategoryName