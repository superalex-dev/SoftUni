SELECT TOP 5 Name AS 'Game Name', Users.Username
FROM Games 
LEFT JOIN UsersGames
ON Games.Id = UsersGames.GameId
LEFT JOIN Users ON Users.Id = UsersGames.UserId
WHERE Duration = 5
ORDER BY Start