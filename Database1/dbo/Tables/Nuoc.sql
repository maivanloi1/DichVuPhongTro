CREATE TABLE [dbo].[Nuoc] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [Ngay]      DATETIME        NULL,
    [SoChuNuoc] FLOAT (53)      NULL,
    [DonGia]    DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

