INSERT INTO [dbo].[Transaction] ([transNum], [accountNum], [transType], [amount], [fromAccount], [toAccount], [dateTime]) VALUES (10001, N'000002', N'Withdrawal', 50, N'-1', N'-1', N'2023-05-07')
INSERT INTO [dbo].[Transaction] ([transNum], [accountNum], [transType], [amount], [fromAccount], [toAccount], [dateTime]) VALUES (10002, N'000002', N'Transfer', 45, N'2', N'1', N'2023-05-07')
INSERT INTO [dbo].[Transaction] ([transNum], [accountNum], [transType], [amount], [fromAccount], [toAccount], [dateTime]) VALUES (10003, N'000002', N'Transfer', 10, N'2', N'3', N'2023-05-07')

DELETE FROM [dbo].[Transaction] WHERE [accountNum] = '000001';
DELETE FROM [dbo].[Transaction] WHERE [accountNum] = '000002';
DELETE FROM [dbo].[Transaction] WHERE [accountNum] = '000003';