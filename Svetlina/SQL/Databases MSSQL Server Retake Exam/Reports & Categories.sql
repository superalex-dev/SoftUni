SELECT R.Description, C.Name AS CategoryName
FROM Reports AS R
JOIN Categories AS C ON C.Id = CategoryId
WHERE CategoryId IS NOT NULL
ORDER BY Description ASC, CategoryName ASC