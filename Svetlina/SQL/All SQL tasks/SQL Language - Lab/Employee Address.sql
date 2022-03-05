SELECT TOP 5 EmployeeID, JobTitle, a.[AddressID], AddressText
From Employees AS e
JOIN Addresses AS a ON a.AddressID =  e.AddressID
ORDER BY a.[AddressID]