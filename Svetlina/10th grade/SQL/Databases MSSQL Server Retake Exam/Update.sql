UPDATE Reports
SET CloseDate = YEAR(GETDATE())
WHERE CloseDate IS NULL