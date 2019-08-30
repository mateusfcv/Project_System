using Mateus.SistemaAcademico.Models;
using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mateus.SistemaAcademico.Filtro
{
    public class AutorizacaoFilter : ActionFilterAttribute
    {
        public TipoPerfil[] Roles { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool isLogin = false;
            object usuario = filterContext.HttpContext.Session["usuarioLogado"];

            if (usuario != null && usuario is Usuario)
            {
                if (Roles != null && Roles.Length > 0)
                {
                    TipoPerfil tipoPerfil = (TipoPerfil)(usuario as Usuario).TipoPerfil;
                    int indexOf = Array.IndexOf(Roles, tipoPerfil);
                    if (indexOf > -1)
                    {
                        isLogin = true;
                    }
                }
                else
                {
                    isLogin = true;
                }
            }

            if (!isLogin)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Login", action = "Index" }));
            }
        }
    }
}