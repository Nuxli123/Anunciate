USE [ZavaletaTowers]
GO
/****** Object:  StoredProcedure [dbo].[usp_SelectInmueblesByClienteProyecto]    Script Date: 23/04/2019 17:52:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[usp_SelectInmueblesByClienteProyecto]
	@ProyectoId int,
	@ClienteId int,
	@UsuarioId nvarchar(128)
AS
BEGIN
	SELECT Proyectos.Nombre as Proyecto, referencias.preciopactado, (ISNULL(SUM(Abonos.Importe),0)+ISNULL(Referencias.Importe,0)) as Pagado, recibos.fecha as FechaAsignacion,
		ISNULL(STUFF((SELECT  Torres.Nombre + ' ' + Niveles.Nombre+CONVERT(varchar(10), Oficinas.Numero) +', 'FROM RecibosInmuebles INNER JOIN Oficinas on Oficinas.Id=RecibosInmuebles.OficinaId 
			INNER JOIN Niveles ON Oficinas.Nivel=Niveles.Id
			INNER JOIN Torres ON Niveles.TorreId=Torres.Id
		WHERE RecibosInmuebles.ReciboId = Recibos.Id AND (Oficinas.ProyectoId = @ProyectoId OR @ProyectoId IS NULL)
		FOR XML PATH ('')), 1, 0, ''),'')+
		ISNULL(STUFF((SELECT  CONVERT(varchar(10), Locales.Numero) +', 'FROM RecibosInmuebles INNER JOIN Locales on Locales.Id=RecibosInmuebles.LocalId 
		WHERE RecibosInmuebles.ReciboId = Recibos.Id AND (Locales.ProyectoId = @ProyectoId OR @ProyectoId IS NULL)
		FOR XML PATH ('')), 1, 0, ''),'')+
		ISNULL(STUFF((SELECT  Torres.Nombre + ' ' +cast(Niveles.numero as nvarchar(2))+'0'+CONVERT(varchar(10), Ubicaciones.Numero) +', 'FROM RecibosInmuebles INNER JOIN Ubicaciones on Ubicaciones.Id=RecibosInmuebles.DepartamentoId 
		INNER JOIN Niveles ON Ubicaciones.NivelId=Niveles.Id
		INNER JOIN Torres ON Niveles.TorreId=Torres.Id
		WHERE RecibosInmuebles.ReciboId = Recibos.Id AND (Ubicaciones.ProyectoId = @ProyectoId OR @ProyectoId IS NULL)
		FOR XML PATH ('')), 1, 0, ''),'')  AS Numero, 0 as M2,Referencias.Id as IdReferencia,
		'[' + substring(STUFF(
	(SELECT  CONVERT(varchar(10), u.Id) +', '
	FROM RecibosInmuebles rec
	inner join  Ubicaciones u on u.Id = rec.DepartamentoId
	WHERE rec.ReciboId = Recibos.Id
	FOR XML PATH (''))
	, 1, 0, ''),0,len(STUFF(
	(SELECT  CONVERT(varchar(10), case when rec.DepartamentoId is not null then rec.DepartamentoId when rec.LocalId is not null then rec.LocalId when rec.OficinaId is not null then rec.OficinaId end) +', '
	FROM RecibosInmuebles rec
	WHERE rec.ReciboId = Recibos.Id
	FOR XML PATH (''))
	, 1, 0, ''))) + ']'  AS IdInmuebles,
	(select top(1) case when re.LocalId is not null then 2 when re.DepartamentoId is not null then 1 when re.OficinaId is not null then 3 end
	from RecibosInmuebles re
	where re.ReciboId = Recibos.Id) as InmuebleTipo
	FROM Contratos
		INNER JOIN Referencias ON Contratos.ReferenciaId=Referencias.Id AND Referencias.ClienteId=@ClienteId
		INNER JOIN Clientes ON Clientes.Id=Referencias.ClienteId 
		INNER JOIN Proyectos ON Proyectos.Id=Referencias.ProyectoId
		INNER JOIN Recibos ON Recibos.ReferenciaId=Referencias.Id
		INNER JOIN RecibosInmuebles ON  Recibos.Id=RecibosInmuebles.ReciboId	
		LEFT JOIN Abonos ON Abonos.ContratoId=Contratos.Id AND (Abonos.Estatus=2 OR Abonos.Estatus=3)
	WHERE (Proyectos.Id = @ProyectoId OR @ProyectoId IS NULL) and Referencias.ProyectoId in (select ProyectoId from UsuariosProyectos where UsuarioId=@UsuarioId)
	GROUP BY Clientes.Id, Clientes.Nombre, Proyectos.Nombre, Recibos.Id, referencias.preciopactado, Referencias.Importe, recibos.fecha,Referencias.Id


END
