using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mateus.SistemaAcademico.Bussines;
using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;
using Mateus.SistemaAcademico.Models.Enums;

namespace Mateus.SistemaAcademico.Controllers
{
    public class TelefonesController : Controller
    {
        // get: telefones
        TelefonesDAO telefonesDAO = new TelefonesDAO();

        [HttpPost]
        public ActionResult AdicionarTelefone(Telefone telefone)
        {
            telefonesDAO.Adicionar(telefone);
            return RedirectToAction("Index", "Telefones");
        }

        [HttpGet]
        public ActionResult AdicionarTelefone()
        {
                var telefone = new Telefone();
                return View(telefone);
        }

        // Remover Telefone
        [HttpGet]
        public ActionResult RemoverTelefone(int Id)
        {
            Telefone telefone = telefonesDAO.BuscaPorId(Id);
            return View(telefone);
        }

        [HttpPost]
        public ActionResult RemoverTelefone(Telefone telefone)
        {
            telefonesDAO.Remover(telefone);
            return RedirectToAction("Index", "Telefones");
        }

        // Editar Telefone
        [HttpGet]
        public ActionResult EditarTelefone(int id)
        {
            var telefonesDAO = new TelefonesDAO();
            Telefone telefone = telefonesDAO.BuscaPorId(id);
            return View(telefone);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarTelefone([Bind(Include = "Id, Numero, TipoTelefone")]Telefone telefone)
        {
            telefonesDAO = new TelefonesDAO();
            telefonesDAO.Editar(telefone);
            return RedirectToAction("Index", "Telefones");
        }

        public ActionResult ListarTelefone()
        {
            IList<Telefone> telefones = telefonesDAO.ListarTelefones();
            return View(telefones);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Telefone telefone = telefonesDAO.BuscaPorId(id);
            return View(telefone);
        }

        public ActionResult Index()
        {
            var telefonesDAO = new TelefonesDAO();
            var telefones = telefonesDAO.ListarTelefones();
            ViewBag.Telefones = telefones;
            return View();
        }
    }
}