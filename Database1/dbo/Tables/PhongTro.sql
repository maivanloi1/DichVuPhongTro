CREATE TABLE [dbo].[PhongTro] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [SoPhong]   INT             NULL,
    [TinhTrang] NVARCHAR (20)   NULL,
    [LoaiPhong] NVARCHAR (15)   NULL,
    [DonGia]    DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

