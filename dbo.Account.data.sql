INSERT INTO [dbo].[Account] ([accountNum], [customerID], [dailyTransDate], [dailyTransTotal], [dailyDepositAmt], [balance]) VALUES (N'000001', N'123456789', N'2023-05-08', 0, 0, 325.67)
INSERT INTO [dbo].[Account] ([accountNum], [customerID], [dailyTransDate], [dailyTransTotal], [dailyDepositAmt], [balance]) VALUES (N'000002', N'123456789', N'2023-05-08', 0, 0, 3905.5)
INSERT INTO [dbo].[Account] ([accountNum], [customerID], [dailyTransDate], [dailyTransTotal], [dailyDepositAmt], [balance]) VALUES (N'000003', N'123456789', N'2023-05-08', 0, 0, 980.01)
INSERT INTO [dbo].[Account] ([accountNum], [customerID], [dailyTransDate], [dailyTransTotal], [dailyDepositAmt], [balance]) VALUES (N'111111', N'111111111', N'2023-05-08', 0, 0, 100.00)
INSERT INTO [dbo].[Account] ([accountNum], [customerID], [dailyTransDate], [dailyTransTotal], [dailyDepositAmt], [balance]) VALUES (N'111112', N'111111111', N'2023-05-08', 0, 0, 19654.11)
INSERT INTO [dbo].[Account] ([accountNum], [customerID], [dailyTransDate], [dailyTransTotal], [dailyDepositAmt], [balance]) VALUES (N'222221', N'777888999', N'2023-05-08', 0, 0, 5555.25)
INSERT INTO [dbo].[Account] ([accountNum], [customerID], [dailyTransDate], [dailyTransTotal], [dailyDepositAmt], [balance]) VALUES (N'333331', N'555555555', N'2023-05-08', 0, 0, 9898.77)

DELETE FROM [dbo].[Account] WHERE [customerID] = '123456789';
DELETE FROM [dbo].[Account] WHERE [customerID] = '111111111';
DELETE FROM [dbo].[Account] WHERE [customerID] = '555555555';
DELETE FROM [dbo].[Account] WHERE [customerID] = '777888999';
