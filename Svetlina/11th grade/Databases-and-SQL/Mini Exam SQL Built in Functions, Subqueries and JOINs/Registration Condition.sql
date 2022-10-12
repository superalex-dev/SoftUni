CREATE VIEW [V_UsersRegistrationAfter2014] AS
SELECT FirstName, LastName
FROM Users
WHERE RegistrationDate > 2014