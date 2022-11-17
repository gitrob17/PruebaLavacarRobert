CREATE TRIGGER [dbo].[RegistroBitacoraServicio]
   ON [dbo].[Servicios]
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   INSERT INTO Bitacora (Fecha_Creacion, Registro_Agregado) VALUES (GETDATE(), 'Servicio')

END
