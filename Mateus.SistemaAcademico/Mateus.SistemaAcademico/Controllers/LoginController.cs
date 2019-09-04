using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Filtro;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mateus.SistemaAcademico.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String login, String senha)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuario = dao.Busca(login, senha);

            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                //guardar sessão de usuários pra personalizar informações das views
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Senha inválida.");
                return RedirectToAction("Index");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            HttpContext.Session.Abandon();

            return RedirectToAction("Index");
        }
    }
}