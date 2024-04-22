CREATE TABLE [dbo].[Dien] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [Ngay]      DATETIME        NULL,
    [SoChuDien] FLOAT (53)      NULL,
    [DonGia]    DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

