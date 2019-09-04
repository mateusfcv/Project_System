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
    [AutorizacaoFilter]
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        UsuariosDAO usuariosDAO = new UsuariosDAO();

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpPost]
        public ActionResult AdicionarUsuario(Usuario usuario)
        {
            usuariosDAO.Adicionar(usuario);
            return RedirectToAction("Index", "Usuarios");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpGet]
        public ActionResult AdicionarUsuario()
        {
            var usuario = new Usuario();
            return View(usuario);

        }

        // Remover Usuario
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpGet]
        public ActionResult RemoverUsuario(int Id)
        {
            Usuario usuario = usuariosDAO.BuscaPorId(Id);
            return View(usuario);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpPost]
        public ActionResult RemoverUsuario(Usuario usuario)
        {
            usuariosDAO.Remover(usuario);
            return RedirectToAction("Index", "Usuarios");
        }

        // Editar Usuario
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpGet]
        public ActionResult EditarUsuario(int id)
        {
            var usuariosDAO = new UsuariosDAO();
            Usuario usuario = usuariosDAO.BuscaPorId(id);
            return View(usuario);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarUsuario([Bind(Include = "Id, NomeUsuario, Senha, TipoPerfil")]Usuario usuario)
        {
            usuariosDAO = new UsuariosDAO();
            usuariosDAO.Editar(usuario);
            return RedirectToAction("Index", "Usuarios");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        public ActionResult ListarUsuario()
        {
            IList<Usuario> usuarios = usuariosDAO.Lista();
            return View(usuarios);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        public ActionResult VisualizarDetalhes(int id)
        {
            Usuario usuario = usuariosDAO.BuscaPorId(id);
            return View(usuario);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        public ActionResult Index()
        {
            UsuariosDAO usuariosDAO = new UsuariosDAO();
            IList<Usuario> usuarios = usuariosDAO.Lista();
            ViewBag.Usuarios = usuarios;
            return View();
        }

        
    }
}
