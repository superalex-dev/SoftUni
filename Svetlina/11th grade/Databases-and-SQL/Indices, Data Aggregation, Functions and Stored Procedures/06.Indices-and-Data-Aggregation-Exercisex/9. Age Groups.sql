SELECT
	CASE
		WHEN Age BETWEEN 0 and 10
			THEN '[0-10]'
		WHEN Age BETWEEN 11 and 20
			THEN '[11-20]'
		WHEN Age BETWEEN 21 and 30
			THEN '[21-30]'
		WHEN Age BETWEEN 31 and 40
			THEN '[31-40]'
		WHEN Age BETWEEN 41 and 50
			THEN '[41-50]'
		WHEN Age BETWEEN 51 and 60
			THEN '[51-60]'
		WHEN Age >= 61 
			THEN '[61+]'
	END AS [AgeGroup],
COUNT(*) AS [WizardCount]
FROM WizzardDeposits

GROUP BY CASE
	WHEN Age BETWEEN 0 and 10
			THEN '[0-10]'
		WHEN Age BETWEEN 11 and 20
			THEN '[11-20]'
		WHEN Age BETWEEN 21 and 30
			THEN '[21-30]'
		WHEN Age BETWEEN 31 and 40
			THEN '[31-40]'
		WHEN Age BETWEEN 41 and 50
			THEN '[41-50]'
		WHEN Age BETWEEN 51 and 60
			THEN '[51-60]'
		WHEN Age >= 61 
			THEN '[61+]'
	END