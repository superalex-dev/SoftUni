SELECT U.Username, C.Name AS CategoryName
FROM Reports AS R
JOIN Users AS U ON U.Id = R.UserId
JOIN Categories AS C ON C.Id = R.CategoryId
ORDER BY U.Username ASC, CategoryName ASC