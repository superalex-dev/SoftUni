CREATE PROCEDURE usp_GetOrdersOfStaff(@staffId int)
AS
BEGIN
    SELECT s.StaffId,
	FirstName 
	AS "First Name", 
	LastName 
	AS "Last Name", 
	COUNT(o.orderId) 
	AS "Orders Count"
    FROM Staffs AS s
    JOIN orders AS o 
	ON o.StaffId = s.staffId
    WHERE s.staffId = @staffId
    GROUP BY s.StaffId, s.FirstName, s.LastName
END
