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
	[Table("Negocios")]
	public class Negocios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int CategoriaNegocioId { get; set; } //(int, not null)
		[Required]
		[StringLength(40)]
		public string Nombre { get; set; } //(varchar(40), not null)
		[Required]
		[StringLength(1000)]
		public string ImagenFondo { get; set; } //(varchar(1000), not null)
		[Required]
		public int Orden { get; set; } //(int, not null)
		[StringLength(1000)]
		public string ImagenFondo2 { get; set; } //(varchar(1000), null)
		[StringLength(10)]
		public string Latitud { get; set; } //(varchar(10), null)
		[StringLength(10)]
		public string Longitud { get; set; } //(varchar(10), null)
		[StringLength(10)]
		public string Altitud { get; set; } //(varchar(10), null)
        [StringLength(500)]
        public string AcercaDe { get; set; }

       public decimal Calificacion { get; set; }

        public bool Aprobado { get; set; }

    }
}
