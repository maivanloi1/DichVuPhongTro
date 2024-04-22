CREATE TABLE [dbo].[NguoiThue] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [HoTen]   NVARCHAR (30) NULL,
    [SDT]     VARCHAR (10)  NULL,
    [CCCD]    VARCHAR (12)  NULL,
    [QueQuan] NVARCHAR (45) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

