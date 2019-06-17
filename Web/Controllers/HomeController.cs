using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using anunciate.Business;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [HttpPost]
        [ActionName("Index")]
        public async Task<IActionResult> Login(anunciate.Domain.Virtual.Request.LoginRequest model)
        {
            if(ModelState.IsValid)
            { 

            var usuario = new UsuariosBo().dao.ObtieneUsuariobyEmail(model.UsuarioEmail);

                if (usuario != null)
                {
                    var correcto = anunciate.Business.Tools.Utilidades.VerifyHashedPassword(usuario.Password, model.Password);

                    if (correcto)
                    {
                        var role = new UsuariosRolesBo().dao.SelectByKey(new anunciate.Domain.UsuariosRoles { UsuarioId = usuario.Id, RoleId = 1 });

                        if (role != null)
                        {
                            var claims = new List<Claim>
                            {
                            new Claim(ClaimTypes.Name,usuario.Id.ToString()),
                            new Claim(ClaimTypes.Role,"Administrador")
                            };
                            var claimsIdentity = new ClaimsIdentity(claims,
                                CookieAuthenticationDefaults.AuthenticationScheme);
                            var authProperties = new AuthenticationProperties
                            {
                                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(120)
                            };
                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal
                                  (claimsIdentity), authProperties);
                            return RedirectToAction("Index", "Usuarios");
                        }
                        else
                        {
                            ModelState.AddModelError("", "El usuario no tiene los permisos adecuados");
                            return View(model);
                        }

                    }
                    else
                    {
                        ModelState.AddModelError("", "Contraseña incorrecta");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Acceso incorrecto");
                    return View(model);
                }
                }
                else
                {
                    return View(model);
                }

            }
        



    }
}
