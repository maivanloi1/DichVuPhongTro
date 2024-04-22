CREATE TABLE [dbo].[PhieuChi] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [SoCT]     NVARCHAR (45)   NULL,
    [Ngay]     DATETIME        NULL,
    [TongTien] DECIMAL (10, 2) NULL,
    [NoiDung]  NVARCHAR (30)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

