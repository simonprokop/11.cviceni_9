CREATE TABLE [dbo].[Connections] (
    [Student]   NVARCHAR (50) NOT NULL,
    [IDS]       INT           NOT NULL,
    [Shortcuts] NVARCHAR (10) NOT NULL,
    CONSTRAINT [FK_Connections_Students] FOREIGN KEY ([IDS]) REFERENCES [dbo].[Students] ([ID]),
    CONSTRAINT [FK_Connections_Subject] FOREIGN KEY ([Shortcuts]) REFERENCES [dbo].[Subjects] ([Shortcut])
);

