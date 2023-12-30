CREATE TABLE [dbo].[Players] (
    [PlayerId]         INT           IDENTITY (1, 1) NOT NULL,
    [PlayerName]       NVARCHAR (50) NOT NULL,
    [TotalGamesPlayed] INT           NOT NULL,
    [Wins]             INT           NOT NULL,
    [Loses]            INT           NOT NULL,
    [Draws]            INT           NOT NULL,
    [LastLogin]        DATE          NOT NULL,
    [Password] NVARCHAR(20) NOT NULL, 
    PRIMARY KEY CLUSTERED ([PlayerId] ASC)
);

