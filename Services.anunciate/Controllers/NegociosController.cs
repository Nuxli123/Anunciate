using anunciate.Business;
using anunciate.Domain;
using anunciate.Domain.Virtual.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.anunciate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegociosController:Controller
    {

        [HttpPost("ObtenerNegocios")]
        public ResponseNegocios ObtenerNegocios(int IdCategoriaNegocio)
        {
            ResponseNegocios response = new ResponseNegocios();


            try
            {
                var ListaNegocios = new NegociosBo().dao.ObtieneNegociosByeCategoria(IdCategoriaNegocio);

                if (ListaNegocios != null)
                {
                    if (ListaNegocios.Count > 0)
                    {
                        response.Estatus = true;
                        response.ListaNegocios = ListaNegocios;
                        response.Mensaje = "Datos encontrados";
                    }
                    else
                    {
                        response.Estatus = false;
                        response.Mensaje = "Datos no encontrados";
                    }


                }
                else
                {
                    response.Estatus = false;
                    response.Mensaje = "Datos no encontrados";
                }

            }
            catch(Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            


            return response;


        }

        [HttpPost("ObtieneNegociosTodos")]
        public ResponseNegocios ObtieneNegociosTodos()
        {
            ResponseNegocios response = new ResponseNegocios();


            try
            {
                var ListaNegocios = new NegociosBo().dao.SelectAll();

                if (ListaNegocios != null)
                {
                    if (ListaNegocios.Count > 0)
                    {
                        response.Estatus = true;
                        response.ListaNegocios = ListaNegocios;
                        response.Mensaje = "Datos encontrados";
                    }
                    else
                    {
                        response.Estatus = false;
                        response.Mensaje = "Datos no encontrados";
                    }


                }
                else
                {
                    response.Estatus = false;
                    response.Mensaje = "Datos no encontrados";
                }

            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }



            return response;
        }


        [HttpPost("ObtieneDetalleneByNegocio")]
        public ResponseDetalleNegocio ObtieneDetalleneByNegocio(int IdNegocio)
        {
            ResponseDetalleNegocio response = new ResponseDetalleNegocio();

            var model = new Negocios();
            model.Id = IdNegocio;
            var negocio = new NegociosBo().SelectByKey(model);
            var Horarios = new HorariosNegociosBo().dao.ObtieneHorariosNegocioById(model.Id);
            var Telefonos = new TelefonosNegociosBo().dao.ObtieneTelefonosNegocioId(model.Id);

            if(negocio != null)
            {
                response.Estatus = true;
                response.Id = negocio.Id;
                response.CategoriaNegocioId = negocio.CategoriaNegocioId;
                response.Nombre = negocio.Nombre;
                response.ImagenFondo = negocio.ImagenFondo;
                response.Orden = negocio.Orden;
                response.ImagenFondo2 = negocio.ImagenFondo2;
                response.Latitud = negocio.Latitud;
                response.Longitud = negocio.Longitud;
                response.AcercaDe = negocio.AcercaDe;
                response.Horarios = Horarios;
                response.Telefonos = Telefonos;
                response.Mensaje = "Negocio encontrado";
            }
            else
            {
                response.Estatus = false;
                response.Mensaje = "Negocio no encontrado";
            }

            return response;

        }

        

        [HttpPost("RegistraComentariosNegocio")]
        public ResponseBase RegistraComentariosNegocio(ComentariosNegocios modelComentarios)
        {
            ResponseBase response = new ResponseBase();


            var model = new ComentariosNegociosBo().dao.Insert(modelComentarios);

            if(model != null)
            {
                response.Estatus = true;
                response.Mensaje = "Los comentarios  se registrarón con exito";
            }
            else
            {
                response.Estatus = false;
                response.Mensaje = "No fue posible registrar los comentarios";
            }

            return response;
        }

        [HttpPost("RegistraCalificacionNegocio")]
        public ResponseBase RegistraCalificacionNegocio(CalificacionesNegocios modelCalificaciones)
        {
            ResponseBase response = new ResponseBase();

            var model = new CalificacionesNegociosBo().Insert(modelCalificaciones);

            if(model != null)
            {
                response.Estatus = true;
                response.Mensaje = "La calificación se registro con éxito";
            }
            else
            {
                response.Estatus = false;
                response.Mensaje = "No fue posible registrar la calificación";
            }

            return response;

        }


        [HttpPost("ObtenerComentariosUsuario")]
        public ResponseComentarios ObtieneComentariosUsuario(int IdUsuario)
        {
            ResponseComentarios response = new ResponseComentarios();

            response.Comentarios = new ComentariosNegociosBo().GetAll();

            var comentarios = response.Comentarios.Where(x => x.UsuarioId == IdUsuario).ToList();

            if(comentarios != null)
            {
                response.Comentarios = comentarios;
                response.Estatus = true;
                response.Mensaje = "Registros encontrados";
            }
            else
            {
                response.Estatus = false;
                response.Mensaje = "No se encontrarón resultados";
            }

            return response;

        }

        [HttpPost("ObtieneComentariosTodos")]
        public ResponseComentarios ObtieneComentariosTodos(int NegocioId)
        {
            ResponseComentarios response = new ResponseComentarios();

            var model = new ComentariosNegociosBo().GetAll();

            var comentarios = model.Where(i => i.NegocioId == NegocioId).ToList();
            

            if (comentarios != null)
            {
                response.Comentarios = comentarios;
                response.Estatus = true;
                response.Mensaje = "Registros encontrados";
            }
            else
            {
                response.Estatus = false;
                response.Mensaje = "No se encontrarón resultados";
            }

            return response;

        }



        [HttpPost("ObtieneCalificacionesbyNegocio")]
        public ResponseCalificaciones ObtieneCalificacionesbyNegocio(int NegocioId)
        {
            ResponseCalificaciones response = new ResponseCalificaciones();

            var calificaciones = new CalificacionesNegociosBo().dao.ObtieneCalificacionbyNegocioId(NegocioId);

            if(calificaciones.Count() > 0)
            {
                response.Calificaciones = calificaciones;
                response.Estatus = true;
                response.Mensaje = "Calificaciones encontradas";
            }
            else
            {
                response.Estatus = false;
                response.Mensaje = "No se encontraron calificaciones";
            }

            return response;

        }


        [HttpGet("ObtenerPromociones")]
        public ResposePromociones ObtenerPromociones()
        {
            ResposePromociones response = new ResposePromociones();

            var promociones = new PromocionesBo().dao.ObtenerPromocionesNegocios();

            try
            {
                if(promociones.Count() > 0)
                {
                    response.Estatus = true;
                    response.Promociones = promociones;
                    response.Mensaje = "Promociones encontradas con éxito.";

                }
                else
                {
                    response.Estatus = false;
                    response.Mensaje = "No se encontraron promociones.";
                }

            }
            catch(Exception ex)
            {
                response.Estatus = false;
                response.Mensaje = "";
            }

            return response;
        }

       [HttpGet("ObtenerPromocionesByNegocio")]
        public ResponsePromocionDetalle ObtieneDetallePromocion(int NegocioId)
        {
            ResponsePromocionDetalle response = new ResponsePromocionDetalle();

            var detalle = new PromocionDetalleBo().dao.ObtieneDetallePromocionByNegocio(NegocioId);

            if(detalle.Count() > 0)
            {
                response.Promociones = detalle;
                response.Estatus = true;
                response.Mensaje = "Datos encontrados";

            }
            else
            {
                response.Estatus = false;
                response.Mensaje = "No se encontraron resultados";
            }

            return response;

        }


    }
}
