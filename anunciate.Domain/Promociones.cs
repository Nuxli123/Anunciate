using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace anunciate.Domain
{
	/// <summary>
	/// Autor: Roberto Carlos Luna
	/// Comentarios: Clase de datos
	/// </summary>
	[Table("Promociones")]
	public class Promociones : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		public int NegocioId { get; set; } //(int, null)
		[StringLength(600)]
		public string Imagen { get; set; } //(varchar(600), null)
		public DateTime FechaInicial { get; set; } //(datetime, null)
		public DateTime FechaFinal { get; set; } //(datetime, null)
	}
}
