CREATE TRIGGER tr_Logs_NotificationEmails ON Logs
FOR INSERT
AS
     BEGIN
         INSERT INTO NotificationEmails
         VALUES((SELECT AccountId
		 FROM inserted),
         CONCAT('Balance change for account: ', (SELECT AccountId
		 FROM inserted)),
         CONCAT('On ', FORMAT(GETDATE(), 'dd-MM-yyyy HH:mm'), ' your balance was changed from ', (SELECT OldSum
		 FROM Logs), ' to ', (SELECT NewSum
		 FROM Logs), '.'));
     END