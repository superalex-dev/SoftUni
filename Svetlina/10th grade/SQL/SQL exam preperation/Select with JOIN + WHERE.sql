SELECT *
FROM Location AS L
JOIN Volcanoes AS V ON V.LocationId = L.Id
WHERE Height < 6000