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
	[Table("UsuariosRoles")]
	public class UsuariosRoles : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int UsuarioId { get; set; } //(int, not null)
		[Required]
		[Key, Column(Order=1)]
		public int RoleId { get; set; } //(int, not null)
	}
}
