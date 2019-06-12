using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace anunciate.Domain
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Clase de datos
	/// </summary>
	[Table("PerfilesNegocios")]
	public class PerfilesNegocios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int NegocioId { get; set; } //(int, not null)
		[StringLength(1000)]
		public string ImagenPrincipal { get; set; } //(varchar(1000), null)
		[Required]
		[StringLength(500)]
		public string Direccion { get; set; } //(varchar(500), not null)
		[Required]
		[StringLength(40)]
		public string Telefono { get; set; } //(varchar(40), not null)
		[Required]
		[StringLength(60)]
		public string DiasHorario { get; set; } //(varchar(60), not null)
		[Required]
		[StringLength(60)]
		public string Horas { get; set; } //(varchar(60), not null)
		[Required]
		[StringLength(80)]
		public string Precios { get; set; } //(varchar(80), not null)
		[Required]
		public string Descripcion { get; set; } //(varchar(max), not null)
	}
}
