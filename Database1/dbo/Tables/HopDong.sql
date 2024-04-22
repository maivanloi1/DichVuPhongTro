CREATE TABLE [dbo].[HopDong] (
    [Id]           INT      IDENTITY (1, 1) NOT NULL,
    [Ngay]         DATETIME NULL,
    [NguoiThue_Id] INT      NULL,
    [Dien_Id]      INT      NULL,
    [Nuoc_Id]      INT      NULL,
    [KhaiBao_Id]   INT      NULL,
    [PhongTro_Id]  INT      NULL,
    [PhieuThu_Id]  INT      NULL,
    [PhieuChi_Id]  INT      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Dien_Id]) REFERENCES [dbo].[Dien] ([Id]),
    FOREIGN KEY ([KhaiBao_Id]) REFERENCES [dbo].[KhaiBao] ([Id]),
    FOREIGN KEY ([NguoiThue_Id]) REFERENCES [dbo].[NguoiThue] ([Id]),
    FOREIGN KEY ([Nuoc_Id]) REFERENCES [dbo].[Nuoc] ([Id]),
    FOREIGN KEY ([PhieuChi_Id]) REFERENCES [dbo].[PhieuChi] ([Id]),
    FOREIGN KEY ([PhieuThu_Id]) REFERENCES [dbo].[PhieuThu] ([Id]),
    FOREIGN KEY ([PhongTro_Id]) REFERENCES [dbo].[PhongTro] ([Id])
);

