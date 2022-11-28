CREATE OR ALTER TRIGGER tr_AccountsDelete
ON Accounts
INSTEAD OF DELETE
AS
	UPDATE Accounts SET IsDeleted = 1
		WHERE AccountId IN(SELECT AccountId from deleted)