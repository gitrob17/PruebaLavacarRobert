CREATE TABLE [dbo].[Bitacora](
	[Id_Bitacora] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Creacion] [datetime] NULL,
	[Registro_Agregado] [varchar](50) NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[Id_Bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


