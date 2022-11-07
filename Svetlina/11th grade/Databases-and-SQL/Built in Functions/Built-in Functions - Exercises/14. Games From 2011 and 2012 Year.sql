select TOP (50) Name,
FORMAT(CAST(Start AS DATE), 'yyyy-MM-dd') AS [Start]
from Games
where DATEPART(YEAR, Start) BETWEEN 2011 AND 2012
order by Start, Name