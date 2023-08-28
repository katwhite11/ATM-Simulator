CREATE TABLE [dbo].[Customer] (
    [Id]        INT          NOT NULL,
    [pin]       INT          NOT NULL,
    [firstName] VARCHAR (50) NOT NULL,
    [lastName]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


