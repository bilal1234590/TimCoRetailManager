CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CashierId] NVARCHAR(128) NULL, 
    [SaleDate] DATETIME2 NULL, 
    [SabTotal] MONEY NULL, 
    [Tax] MONEY NULL, 
    [Total] MONEY NULL
)
