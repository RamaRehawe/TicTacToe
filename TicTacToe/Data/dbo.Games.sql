CREATE TABLE [dbo].[Games] (
    [GameId]    INT  NOT NULL IDENTITY,
    [Player1ID] INT  NOT NULL,
    [Player2ID] INT  NOT NULL,
    [WinnerID]  INT  NULL,
    [DatePlay]  DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([GameId] ASC),
    CONSTRAINT [Player1ToID] FOREIGN KEY ([Player1ID]) REFERENCES [dbo].[Players] ([PlayerId]),
    CONSTRAINT [Player2ToID] FOREIGN KEY ([Player2ID]) REFERENCES [dbo].[Players] ([PlayerId]),
    CONSTRAINT [Winner] FOREIGN KEY ([WinnerID]) REFERENCES [dbo].[Players] ([PlayerId])
);

