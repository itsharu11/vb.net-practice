CREATE TABLE [dbo].[Student]
(
	[RegNo] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [DeptID] INT NOT NULL, 
    CONSTRAINT [FK_Student_ToTable] FOREIGN KEY ([DeptID]) REFERENCES [Department]([DeptID]) 
)
