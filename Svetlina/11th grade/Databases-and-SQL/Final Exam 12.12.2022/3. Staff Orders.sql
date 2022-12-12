SELECT c.FirstName, c.LastName,
COUNT(o.OrderId) 
AS Orders
FROM Customers c
JOIN Orders o
ON c.CustomerId = o.CustomerId
GROUP BY c.FirstName, c.LastName
ORDER BY Orders DESC, FirstName ASC