CREATE TABLE [dbo].[Movimento]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Descricao] VARCHAR(50) NULL, 
    [Valor] DECIMAL(18, 2) NULL, 
    [Data] DATE NULL, 
    [Tipo] VARCHAR(20) NULL
)
