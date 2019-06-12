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
	[Table("Usuarios")]
	public class Usuarios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		[StringLength(450)]
		public string Nombre { get; set; } //(varchar(450), not null)
		[Required]
		[StringLength(60)]
		public string NombreUsuario { get; set; } //(varchar(60), not null)
		[Required]
		[StringLength(350)]
		public string Email { get; set; } //(varchar(350), not null)
		[Required]
		[StringLength(1000)]
		public string Password { get; set; } //(varchar(1000), not null)
		[Required]
		public DateTime FechaRegistro { get; set; } //(datetime, not null)
		public DateTime FechaUltimoAcceso { get; set; } //(datetime, null)
		[Required]
		public bool Activo { get; set; } //(bit, not null)

       

		[Required]
		public bool Verificado { get; set; } //(bit, not null)
		[StringLength(40)]
		public string AuthId { get; set; } //(varchar(40), null)
		[StringLength(1000)]
		public string Token { get; set; } //(varchar(1000), null)
		[StringLength(10)]
		public string ProviderAuth { get; set; } //(varchar(10), null)

       
	}
}
