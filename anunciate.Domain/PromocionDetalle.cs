using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace anunciate.Domain
{
	/// <summary>
	/// Autor: Roberto Carlos Luna
	/// Comentarios: Clase de datos
	/// </summary>
	[Table("PromocionDetalle")]
	public class PromocionDetalle : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int PromocionId { get; set; } //(int, not null)
		[StringLength(150)]
		public string TxtProducto { get; set; } //(varchar(150), null)
		[StringLength(250)]
		public string TxtPromocion { get; set; } //(varchar(250), null)

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }
	}
}
