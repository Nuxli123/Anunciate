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
	[Table("NegociosFavoritos")]
	public class NegociosFavoritos : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int UsuarioId { get; set; } //(int, not null)
		[Required]
		[Key, Column(Order=1)]
		public int NegocioId { get; set; } //(int, not null)
	}
}
