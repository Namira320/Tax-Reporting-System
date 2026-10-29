CREATE TABLE [dbo].[tbl_Simulasi] (
    [ID]              INT             IDENTITY (1, 1) NOT NULL,
    [NIK]             VARCHAR (16)    NULL,
    [TanggalSimulasi] DATETIME        DEFAULT (getdate()) NULL,
    [HasilSimulasi]   NVARCHAR (50)   NULL,
    [DetailSimulasi]  NVARCHAR (500)  NULL,
    [PanduanBilling]  NVARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
