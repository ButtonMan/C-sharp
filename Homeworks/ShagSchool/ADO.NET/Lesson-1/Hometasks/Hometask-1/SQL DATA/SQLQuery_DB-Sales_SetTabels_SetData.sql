--+---------------------------------------------------------------------------+
--�������� ���� ������ "�������"
--+---------------------------------------------------------------------------+
--CREATE DATABASE [SALES];
--GO



--+---------------------------------------------------------------------------+
--����������� � ���� ������ "�������"
--+---------------------------------------------------------------------------+
USE [SALES];
GO


--+---------------------------------------------------------------------------+
--�������� ������� "����������"
--+---------------------------------------------------------------------------+
CREATE TABLE [Buyers]
(
[BuyerId] int NOT NULL IDENTITY(1,1) PRIMARY KEY,
[LastName] varchar(255),
[FirstName] varchar(255),
);
GO



--+---------------------------------------------------------------------------+
--�������� ������� "����������"
--+---------------------------------------------------------------------------+
CREATE TABLE [Sellers]
(
[SellerId] int NOT NULL IDENTITY(1,1) PRIMARY KEY,
[LastName] varchar(255) NOT NULL,
[FirstName] varchar(255) NOT NULL,
);
GO



--+---------------------------------------------------------------------------+
--�������� ������� "�������"
--+---------------------------------------------------------------------------+
CREATE TABLE [Sales]
(
[DealId] int NOT NULL IDENTITY(1,1) PRIMARY KEY,
[BuyerId] int NOT NULL FOREIGN KEY REFERENCES [Buyers]([BuyerId]),
[SellerId] int NOT NULL FOREIGN KEY REFERENCES [Sellers]([SellerId]),
[Total] int NOT NULL,
[Date] Date NOT NULL
)
GO



--+---------------------------------------------------------------------------+
--���������� ������� ������� "��������"
--+---------------------------------------------------------------------------+
INSERT INTO [Buyers]  ([LastName], [FirstName])
VALUES ('������������', '�������');
INSERT INTO [Buyers] ([LastName], [FirstName])
VALUES ('������', '���������');
INSERT INTO [Buyers] ([LastName], [FirstName])
VALUES ('��������', '��������');
INSERT INTO [Buyers] ([LastName], [FirstName])
VALUES ('���������', '���������');
INSERT INTO [Buyers] ([LastName], [FirstName])
VALUES ('�������', '������');
INSERT INTO [Buyers] ([LastName], [FirstName])
VALUES ('��������', '�������');
INSERT INTO [Buyers] ([LastName], [FirstName])
VALUES ('������', '�����');
INSERT INTO [Buyers] ([LastName], [FirstName])
VALUES ('���������', '���������');
INSERT INTO [Buyers] ([LastName], [FirstName])
VALUES ('�����', '�����');
INSERT INTO [Buyers] ([LastName], [FirstName])
VALUES ('�����������', '�����');
GO



--+---------------------------------------------------------------------------+
--���������� ������� ������� "����������"
--+---------------------------------------------------------------------------+
INSERT INTO [Sellers]  ([LastName], [FirstName])
VALUES ('���������', '��������');
INSERT INTO [Sellers] ([LastName], [FirstName])
VALUES ('�������', '�����');
INSERT INTO [Sellers] ([LastName], [FirstName])
VALUES ('������', '����');
INSERT INTO [Sellers] ([LastName], [FirstName])
VALUES ('���������', '�����');
INSERT INTO [Sellers] ([LastName], [FirstName])
VALUES ('��������', '����');
INSERT INTO [Sellers] ([LastName], [FirstName])
VALUES ('�����������', '�����');
INSERT INTO [Sellers] ([LastName], [FirstName])
VALUES ('�����������', '�����');
INSERT INTO [Sellers] ([LastName], [FirstName])
VALUES ('���������', '����');
INSERT INTO [Sellers] ([LastName], [FirstName])
VALUES ('�������', '����');
INSERT INTO [Sellers] ([LastName], [FirstName])
VALUES ('�������', '����');
GO



--+---------------------------------------------------------------------------+
--���������� ������� ������� "�������"
--+---------------------------------------------------------------------------+
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (1, 1, 200, '2014-01-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (1, 1, 400, '2014-02-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (1, 1, 600, '2014-03-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (1, 1, 800, '2014-04-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (2, 2, 50, '2014-02-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (2, 2, 100, '2014-03-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (2, 2, 200, '2014-04-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (2, 2, 250, '2014-05-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (3, 3, 200, '2014-03-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (3, 3, 1000, '2014-04-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (3, 3, 1100, '2014-05-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (3, 3, 1200, '2014-06-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (4, 4, 25, '2014-04-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (4, 4, 50, '2014-05-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (4, 4, 75, '2014-06-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (4, 4, 100, '2014-07-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (5, 5, 200, '2014-05-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (5, 5, 250, '2014-06-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (5, 5, 350, '2014-07-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (5, 5, 450, '2014-08-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (6, 6, 800, '2014-06-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (6, 6, 900, '2014-07-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (6, 6, 1000, '2014-08-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (6, 6, 1100, '2014-09-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (7, 7, 600, '2014-07-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (7, 7, 700, '2014-08-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (7, 7, 800, '2014-09-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (7, 7, 900, '2014-10-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (8, 8, 400, '2014-08-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (8, 8, 450, '2014-09-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (8, 8, 500, '2014-10-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (8, 8, 550, '2014-11-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (9, 9, 350, '2014-12-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (9, 9, 400, '2014-09-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (9, 9, 450, '2014-10-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (9, 9, 500, '2014-11-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (10, 10, 10, '2014-12-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (10, 10, 20, '2015-01-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (10, 10, 30, '2015-02-01' );
INSERT INTO [Sales] ([BuyerId], [SellerId], [Total], [Date])
VALUES (10, 10, 40, '2015-03-01' );



--+---------------------------------------------------------------------------+
--������ �� ��������� ���� ������ � ��
--+---------------------------------------------------------------------------+
SELECT [TABLE_NAME]
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='SALES'
GO



--+---------------------------------------------------------------------------+
--������ �� ��������� ���� ������ � ��
--+---------------------------------------------------------------------------+
SELECT *
FROM [Sellers]