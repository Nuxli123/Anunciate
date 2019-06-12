using anunciate.Business;
using anunciate.Business.Tools;
using anunciate.Domain;
using anunciate.Domain.Virtual.Request;
using anunciate.Domain.Virtual.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.anunciate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController:Controller
    {
        [HttpPost("RegistraUsuario")]
        public ResponseUsuario RegistraUsuario(UsuarioRequest modelUsuario)
        {
            Usuarios model = new Usuarios();
            ResponseUsuario response = new ResponseUsuario();
            response.Usuario = new UsuarioBase();

            var hashed = Utilidades.HashPassword(modelUsuario.Password);
           

            model.Nombre = modelUsuario.Nombre;
            model.NombreUsuario = modelUsuario.NombreUsuario;
            model.Email = modelUsuario.Email;
            model.Password = hashed;
            model.FechaRegistro = DateTime.Now;
            model.FechaUltimoAcceso = DateTime.Now;
            model.Activo = true;
            model.Verificado = true;
            
            

            var responseUsuarios = new UsuariosBo().Insert(model);

            if(responseUsuarios != null)
            {
                response.Usuario.IdUsuario = responseUsuarios.Id;
                response.Usuario.NombreUsuario = responseUsuarios.Nombre;
                response.Estatus = true;
                response.Mensaje = "Usuario registrado con éxito";
            }
            else
            {
                response.Estatus = false;
                response.Mensaje = "No fue posible registrar al usuario";
            }

            return response;
        }


        [HttpPost("LoginUsuario")]
        public ResponseUsuario LoginUsuario(LoginRequest login)
        {
            ResponseUsuario response = new ResponseUsuario();
            response.Usuario = new UsuarioBase();


            var usuario = new UsuariosBo().dao.ObtieneUsuariobyEmail(login.UsuarioEmail);

            if(usuario != null)
            {
                var passwordCorrecto = Utilidades.VerifyHashedPassword(usuario.Password, login.Password);

                if(passwordCorrecto)
                {
                    response.Usuario.IdUsuario = usuario.Id;
                    response.Usuario.NombreUsuario = usuario.Nombre;
                    response.Estatus = true;
                    response.Mensaje = "Usuario encontrado";

                }
                else
                {
                    response.Estatus = false;
                    response.Mensaje = "Password incorrecto";
                }


            }
            else
            {
                response.Estatus = false;
                response.Mensaje = "Usuario no encontrado";
            }

            return response;
        }

    }
}
