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
	[Table("CalificacionesNegocios")]
	public class CalificacionesNegocios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int NegocioId { get; set; } //(int, not null)
		[Required]
		public int UsuarioId { get; set; } //(int, not null)
		[Required]
		public DateTime FechaRegistro { get; set; } //(datetime, not null)
		[Required]
		public decimal Calificacion { get; set; } //(int, not null)
	}
}
