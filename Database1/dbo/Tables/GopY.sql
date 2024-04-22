CREATE TABLE [dbo].[GopY] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Ngay]         DATETIME      NULL,
    [TrangThai]    NVARCHAR (20) NULL,
    [NoiDung]      NVARCHAR (45) NULL,
    [NguoiThue_ID] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([NguoiThue_ID]) REFERENCES [dbo].[NguoiThue] ([Id])
);

