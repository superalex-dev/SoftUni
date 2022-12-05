CREATE PROCEDURE usp_AssignProject(@employeeId INT , @projectID INT)
AS
	BEGIN
         BEGIN TRANSACTION;
         INSERT INTO EmployeesProjects(EmployeeID, ProjectID)
         VALUES(@employeeId, @projectID)
         IF((SELECT COUNT(EmployeeID)
			FROM EmployeesProjects
				WHERE EmployeeID = @employeeId) > 3)
		BEGIN
			ROLLBACK
				RAISERROR('The employee has too many projects!', 16, 1);
		END
		COMMIT
	END