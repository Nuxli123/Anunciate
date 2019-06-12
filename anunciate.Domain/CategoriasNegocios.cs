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
	[Table("CategoriasNegocios")]
	public class CategoriasNegocios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		[StringLength(100)]
		public string Nombre { get; set; } //(varchar(100), not null)
		[Required]
		[StringLength(1000)]
		public string Icono { get; set; } //(varchar(1000), not null)
		[Required]
		[StringLength(1000)]
		public string ImagenFondo { get; set; } //(varchar(1000), not null)
		public byte Tipo { get; set; }
	}
}
