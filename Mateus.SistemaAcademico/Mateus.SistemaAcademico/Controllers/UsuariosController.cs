using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Filtro;
using Mateus.SistemaAcademico.Models;
using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mateus.SistemaAcademico.Controllers
{
    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        UsuariosDAO usuariosDAO = new UsuariosDAO();

        [HttpPost]
        public ActionResult AdicionarUsuario(Usuario usuario)
        {
            usuariosDAO.Adicionar(usuario);
            return RedirectToAction("Index", "Usuarios");
        }

        [HttpGet]
        public ActionResult AdicionarUsuario()
        {
            var usuario = new Usuario();
            return View(usuario);

        }

        // Remover Usuario
        [HttpGet]
        public ActionResult RemoverUsuario(int Id)
        {
            Usuario usuario = usuariosDAO.BuscaPorId(Id);
            return View(usuario);
        }

        [HttpPost]
        public ActionResult RemoverUsuario(Usuario usuario)
        {
            usuariosDAO.Remover(usuario);
            return RedirectToAction("Index", "Usuarios");
        }

        // Editar Usuario
        [HttpGet]
        public ActionResult EditarUsuario(int id)
        {
            var usuariosDAO = new UsuariosDAO();
            Usuario usuario = usuariosDAO.BuscaPorId(id);
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarUsuario([Bind(Include = "Id, NomeUsuario, Senha")]Usuario usuario)
        {
            usuariosDAO = new UsuariosDAO();
            usuariosDAO.Editar(usuario);
            return RedirectToAction("Index", "Usuarios");
        }

        public ActionResult ListarUsuario()
        {
            IList<Usuario> usuarios = usuariosDAO.Lista();
            return View(usuarios);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Usuario usuario = usuariosDAO.BuscaPorId(id);
            return View(usuario);
        }
        

        public ActionResult Index()
        {
            UsuariosDAO usuariosDAO = new UsuariosDAO();
            IList<Usuario> usuarios = usuariosDAO.Lista();
            ViewBag.Usuarios = usuarios;
            return View();
        }
    }
}