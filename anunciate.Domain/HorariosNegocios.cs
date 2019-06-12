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

    [Table("HorariosNegocios")]
	public class HorariosNegocios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int NegocioId { get; set; } //(int, not null)
		[Required]
		[StringLength(20)]
		public string HoraInicio { get; set; } //(varchar(20), not null)
		[Required]
		[StringLength(20)]
		public string HoraFin { get; set; } //(varchar(20), not null)
		[Required]
		[StringLength(40)]
		public string Dias { get; set; } //(varchar(40), not null)
	}
}
