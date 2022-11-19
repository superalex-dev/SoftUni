SELECT DepositGroup,
MAX(MagicWandSize)
AS 'LongestMagicWand'
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY DepositGroup ASC