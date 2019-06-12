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
	[Table("PerfilesUsuarios")]
	public class PerfilesUsuarios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int UsuarioId { get; set; } //(int, not null)
		public string Foto { get; set; } //(varchar(max), null)
		public DateTime FechaNacimiento { get; set; } //(datetime, null)
	}
}
