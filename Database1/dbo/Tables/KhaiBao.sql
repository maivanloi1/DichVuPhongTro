CREATE TABLE [dbo].[KhaiBao] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Loai]      NVARCHAR (45) NULL,
    [Ngay]      DATETIME      NULL,
    [TinhTrang] NVARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

