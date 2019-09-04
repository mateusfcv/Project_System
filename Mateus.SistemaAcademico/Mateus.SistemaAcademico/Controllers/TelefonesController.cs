using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mateus.SistemaAcademico.Bussines;
using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Filtro;
using Mateus.SistemaAcademico.Models;
using Mateus.SistemaAcademico.Models.Enums;

namespace Mateus.SistemaAcademico.Controllers
{
    //[AutorizacaoFilter]
    //public class TelefonesController : Controller
    //{
    //    // get: telefones
    //    TelefonesDAO telefonesDAO = new TelefonesDAO();

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
    //    [HttpPost]
    //    public ActionResult AdicionarTelefone(Telefone telefone)
    //    {
    //        telefonesDAO.Adicionar(telefone);
    //        return RedirectToAction("Index", "Telefones");
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
    //    [HttpGet]
    //    public ActionResult AdicionarTelefone()
    //    {
    //            var telefone = new Telefone();
    //            return View(telefone);
    //    }

    //    // Remover Telefone
    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
    //    [HttpGet]
    //    public ActionResult RemoverTelefone(int Id)
    //    {
    //        Telefone telefone = telefonesDAO.BuscaPorId(Id);
    //        return View(telefone);
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
    //    [HttpPost]
    //    public ActionResult RemoverTelefone(Telefone telefone)
    //    {
    //        telefonesDAO.Remover(telefone);
    //        return RedirectToAction("Index", "Telefones");
    //    }

    //    // Editar Telefone
    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
    //    [HttpGet]
    //    public ActionResult EditarTelefone(int id)
    //    {
    //        var telefonesDAO = new TelefonesDAO();
    //        Telefone telefone = telefonesDAO.BuscaPorId(id);
    //        return View(telefone);
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult EditarTelefone([Bind(Include = "Id, Numero, TipoTelefone")]Telefone telefone)
    //    {
    //        telefonesDAO = new TelefonesDAO();
    //        telefonesDAO.Editar(telefone);
    //        return RedirectToAction("Index", "Telefones");
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    public ActionResult ListarTelefone()
    //    {
    //        IList<Telefone> telefones = telefonesDAO.ListarTelefones();
    //        return View(telefones);
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria,
    //        TipoPerfil.Aluno, TipoPerfil.Professor })]
    //    public ActionResult VisualizarDetalhes(int id)
    //    {
    //        Telefone telefone = telefonesDAO.BuscaPorId(id);
    //        return View(telefone);
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria,
    //        TipoPerfil.Aluno, TipoPerfil.Professor })]
    //    public ActionResult Index()
    //    {
    //        var telefonesDAO = new TelefonesDAO();
    //        var telefones = telefonesDAO.ListarTelefones();
    //        ViewBag.Telefones = telefones;
    //        return View();
    //    }
    //}
}