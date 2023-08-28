CREATE TABLE [dbo].[Transaction] (
    [transNum]    INT          NOT NULL,
    [accountNum]  VARCHAR (50) NOT NULL,
    [transType]   VARCHAR (50) NOT NULL,
    [amount]      MONEY   NOT NULL,
    [fromAccount] VARCHAR (50) NOT NULL,
    [toAccount]   VARCHAR (50) NOT NULL,
    [dateTime]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([transNum] ASC)
);

