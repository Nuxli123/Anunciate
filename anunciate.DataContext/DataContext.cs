using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anunciate.Domain;
using anunciate.Domain.Virtual.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace anunciate.DataContext
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Clase de contexto de datos
	/// </summary>
	public class DataContext : DbContext
	{
		public DbSet<Usuarios> Usuarios { get; set; }
		public DbSet<Negocios> Negocios { get; set; }
        public DbSet<ResponseDetalleNegocio> NegociosDetalle { get; set; }
        public DbSet<CaracteristicasNegocios> CaracteristicasNegocios { get; set; }
		public DbSet<CalificacionesNegocios> CalificacionesNegocios { get; set; }
		public DbSet<CategoriasNegocios> CategoriasNegocios { get; set; }
		public DbSet<ComentariosNegocios> ComentariosNegocios { get; set; }
		public DbSet<FotosNegocios> FotosNegocios { get; set; }
		public DbSet<HorariosNegocios> HorariosNegocios { get; set; }
        public DbSet<NegociosFavoritos> NegociosFavoritos { get; set; }
		public DbSet<PerfilesNegocios> PerfilesNegocios { get; set; }
		public DbSet<PerfilesUsuarios> PerfilesUsuarios { get; set; }
		public DbSet<TelefonosNegocios> TelefonosNegocios { get; set; }
        public DbSet<PromocionDetalle> PromocionesDetalle { get; set; }
        public DbSet<Promociones> Promociones { get; set; }
        public DbQuery<ResponsePromocionNegocio> promocionNegocio { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<UsuariosRoles> usuariosroles { get; set; }
        //public DbSet<ResponsePromocionDetalle> promdetalle { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dir = Directory.GetCurrentDirectory();
            var env = Environment.CurrentDirectory;
            //Productivo
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DataContext");
                optionsBuilder.UseSqlServer(connectionString);




            }

            //Local y 77
            //optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=DB_A475E7_nuxli02;User Id=sa;Password=12345678");

            //optionsBuilder.UseSqlServer("Data Source=sql7004.site4now.net;Initial Catalog=DB_A475E7_nuxli02;User Id=DB_A475E7_nuxli02_admin;Password=Nuxli1983");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NegociosFavoritos>().HasKey(table => new
            {
                table.NegocioId,
                table.UsuarioId

            });

            modelBuilder.Entity<UsuariosRoles>().HasKey(table => new
            {
                
                table.UsuarioId,
                table.RoleId

            });



            base.OnModelCreating(modelBuilder);
        }
    }
}
