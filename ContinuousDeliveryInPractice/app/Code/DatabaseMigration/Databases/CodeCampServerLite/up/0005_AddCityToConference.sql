ALTER TABLE [Conference]
ADD City nvarchar(100) NULL

GO

UPDATE Conference SET City = 'Copenhagen'