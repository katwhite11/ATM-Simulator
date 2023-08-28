CREATE TABLE [dbo].[Account] (
    [accountNum]      VARCHAR (50) NOT NULL,
    [customerID]      VARCHAR (50) NOT NULL,
    [dailyTransDate]  VARCHAR(50)         NOT NULL,
    [dailyTransTotal] FLOAT (53)   NOT NULL,
    [dailyDepositAmt] FLOAT (53)   NOT NULL,
    [balance]         FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([accountNum] ASC)
);

