SELECT C.Id, C.Name, C.Population, T.Id, T.Name, T.CountryId, T.GPSLocation
FROM Towns AS T
JOIN Countries AS C ON C.Id = T.CountryId
WHERE Population <= 7000000