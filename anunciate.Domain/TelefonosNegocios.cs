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
    /// 
 
    [Table("TelefonosNegocios")]
	public class TelefonosNegocios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int NegocioId { get; set; } //(int, not null)
		[Required]
		[StringLength(20)]
		public string Telefono { get; set; } //(varchar(20), not null)
	}
}
