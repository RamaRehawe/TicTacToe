CREATE TABLE [dbo].[Games]
(
	[GameId] INT NOT NULL PRIMARY KEY, 
    [Player1ID] INT NOT NULL, 
    [Player2ID] INT NOT NULL, 
    [WinnerID] INT NULL, 
    [DatePlay] DATE NOT NULL
)
