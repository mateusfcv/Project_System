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
    public class ResponsavelController : Controller
    {
        // get: responsavels
        ResponsavelDAO responsavelsDAO = new ResponsavelDAO();

        [HttpPost]
        public ActionResult AdicionarResponsavel(Responsavel responsavel)
        {
            responsavelsDAO.Adicionar(responsavel);
            return RedirectToAction("Index", "Responsavel");
        }

        [HttpGet]
        public ActionResult AdicionarResponsavel(int? alunoId)
        {
                var responsavel = new Responsavel();
                return View(responsavel);
        }

        // Remover Responsavel
        [HttpGet]
        public ActionResult RemoverResponsavel(int Id)
        {
            Responsavel responsavel = responsavelsDAO.BuscaPorId(Id);
            return View(responsavel);
        }

        [HttpPost]
        public ActionResult RemoverResponsavel(Responsavel responsavel)
        {
            responsavelsDAO.Remover(responsavel);
            return RedirectToAction("Index", "Responsavel");
        }

        // Editar Responsavel
        [HttpGet]
        public ActionResult EditarResponsavel(int id)
        {
            var responsavelsDAO = new ResponsavelDAO();
            Responsavel responsavel = responsavelsDAO.BuscaPorId(id);
            return View(responsavel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarResponsavel([Bind(Include = "Id, Nome, Email, Cpf, DataDeNascimento, Escolaridade, EstadoCivil")]Responsavel responsavel)
        {
            responsavelsDAO = new ResponsavelDAO();
            responsavelsDAO.Editar(responsavel);
            return RedirectToAction("Index", "Responsavel");
        }

        public ActionResult ListarResponsavel()
        {
            IList<Responsavel> responsavels = responsavelsDAO.ListarResponsavel();
            return View(responsavels);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Responsavel responsavel = responsavelsDAO.BuscaPorId(id);
            return View(responsavel);
        }

        public ActionResult Index()
        {
            var responsavelsDAO = new ResponsavelDAO();
            var responsavels = responsavelsDAO.ListarResponsavel();
            ViewBag.Responsavel = responsavels;
            return View();
        }
    }
}