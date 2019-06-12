using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace anunciate.Domain
{
	/// <summary>
	/// Autor: anunciate
	/// Comentarios: Clase de datos
	/// </summary>
	[Table("Roles")]
	public class Roles : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		[StringLength(50)]
		public string Nombre { get; set; } //(varchar(50), not null)
	}
}
