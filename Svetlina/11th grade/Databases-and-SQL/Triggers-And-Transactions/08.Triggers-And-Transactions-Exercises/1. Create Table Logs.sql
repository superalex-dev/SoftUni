CREATE TRIGGER tr_Accounts_Logs_After_Update 
ON Accounts
FOR UPDATE
AS
     BEGIN
         INSERT INTO Logs
         VALUES
         (
         (
             SELECT Id
             FROM deleted
         ),
         (
             SELECT Balance
             FROM deleted
         ),
         (
             SELECT Balance
             FROM inserted
         )
         );
		 END;