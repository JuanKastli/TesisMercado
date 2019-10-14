USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[gastosAgregar]    Script Date: 10/07/2019 18:21:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[gastosAgregar] 

@Nro_factura int,
@monto int,
@fecha datetime,
@pago int,
@fecha_pago datetime,
@id_proveedor int
	
AS
BEGIN

	SET NOCOUNT ON;

  INSERT INTO gastos(Nro_factura,monto,fecha,pago,fecha_pago,id_proveedor)
  VALUES (@Nro_factura,@monto,@fecha,@pago,@fecha_pago,@id_proveedor)

END


GO

