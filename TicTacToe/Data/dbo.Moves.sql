CREATE TABLE [dbo].[Moves] (
    [MoveId]      INT      NOT NULL,
    [GameId]      INT      NOT NULL,
    [PlayerId]    INT      NOT NULL,
    [MoveNumber]  INT      NOT NULL,
    [RowIndex]    INT      NOT NULL,
    [ColumnIndex] INT      NOT NULL,
    [Symbol]      CHAR (2) NOT NULL,
    PRIMARY KEY CLUSTERED ([MoveId] ASC),
    CONSTRAINT [Pord] FOREIGN KEY ([GameId]) REFERENCES [dbo].[Games] ([GameId]), 
    CONSTRAINT [Player] FOREIGN KEY ([PlayerId]) REFERENCES [Players]([PlayerId])
);

