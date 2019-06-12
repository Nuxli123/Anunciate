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
	[Table("FotosNegocios")]
	public class FotosNegocios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int NegocioId { get; set; } //(int, not null)
		[Required]
		public string Foto { get; set; } //(varchar(max), not null)
		[StringLength(100)]
		public string Descripcion { get; set; } //(varchar(100), null)
	}
}
