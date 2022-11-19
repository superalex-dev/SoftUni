SELECT DepartmentID, 
	(SELECT DISTINCT Salary 
		FROM Employees 
			WHERE DepartmentID = e.DepartmentID 
				ORDER BY Salary 
					DESC OFFSET 2 
						ROWS FETCH NEXT 1 ROWS ONLY) 
							AS ThirdHighestSalary
FROM Employees e
WHERE (SELECT DISTINCT Salary 
	FROM Employees 
		WHERE DepartmentID = e.DepartmentID 
			ORDER BY Salary 
				DESC OFFSET 2 
					ROWS FETCH NEXT 1 ROWS ONLY) IS NOT NULL
GROUP BY DepartmentID