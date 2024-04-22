CREATE TABLE [dbo].[ThietBi] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [TenTB]       NVARCHAR (20)   NULL,
    [Gia]         DECIMAL (10, 2) NULL,
    [NgayMua]     DATETIME        NULL,
    [ThoiGianBH]  NVARCHAR (10)   NULL,
    [PhongTro_Id] INT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([PhongTro_Id]) REFERENCES [dbo].[PhongTro] ([Id])
);

