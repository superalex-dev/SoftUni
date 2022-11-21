CREATE PROCEDURE usp_SendMoney(@senderAccountId INT,
@receiverAccountId INT,
@amount DECIMAL(16 ,2))
AS
BEGIN TRANSACTION
DECLARE @senderAccount INT =
(
SELECT AccountId
FROM Accounts
WHERE AccountId = @senderAccountId
)

DECLARE @receiverAccount INT =
(
SELECT AccountId
FROM Accounts
WHERE AccountId = @receiverAccountId
)

IF(@senderAccount IS NULL OR @receiverAccount IS NULL)
BEGIN
ROLLBACK
RAISERROR('Account doesn''t exists!', 16,1)
RETURN
END

DECLARE @currentAmount  DECIMAL =
(
SELECT Balance
FROM Accounts
WHERE AccountId = @senderAccountId
)

IF(@currentAmount - @amount < 0)
BEGIN
ROLLBACK
RAISERROR('Insufficient funds!',16,2)
RETURN
END

UPDATE Accounts
SET Balance -= @amount
WHERE AccountId = @senderAccountId

UPDATE Accounts
SET Balance += @amount
WHERE AccountId = @receiverAccountId

COMMIT
