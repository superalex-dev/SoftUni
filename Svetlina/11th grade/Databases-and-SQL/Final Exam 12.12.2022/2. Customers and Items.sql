SELECT c.FirstName, c.LastName, i.[Name] 
	AS 'Item Name', 
		i.Quantity 
			AS 'Bought Quantity'
FROM Customers AS c
JOIN Orders AS o
ON c.CustomerId = o.CustomerId
JOIN Items AS i
ON o.OrderId = i.OrderId
WHERE i.Quantity >= 5
ORDER BY i.Quantity DESC