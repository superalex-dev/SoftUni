SELECT DepositGroup,
SUM(DepositAmount)
AS 'TotalSum'
from WizzardDeposits
GROUP BY DepositGroup