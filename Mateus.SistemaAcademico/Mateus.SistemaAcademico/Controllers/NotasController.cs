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
    public class NotasController : Controller
    {
        // get: notas
        NotasDAO notasDAO = new NotasDAO();

        [HttpPost]
        public ActionResult AdicionarNotas(Notas notas)
        {
            notasDAO.Adicionar(notas);
            return RedirectToAction("Index", "Notas");
        }

        [HttpGet]
        public ActionResult AdicionarNotas()
        {
                var notas = new Notas();
                return View(notas);
        }

        // Remover Notas
        [HttpGet]
        public ActionResult RemoverNotas(int Id)
        {
            Notas notas = notasDAO.BuscaPorId(Id);
            return View(notas);
        }

        [HttpPost]
        public ActionResult RemoverNotas(Notas notas)
        {
            notasDAO.Remover(notas);
            return RedirectToAction("Index", "Notas");
        }

        // Editar Notas
        [HttpGet]
        public ActionResult EditarNotas(int id)
        {
            var notasDAO = new NotasDAO();
            Notas notas = notasDAO.BuscaPorId(id);
            return View(notas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarNotas([Bind(Include = "Id, AlunoId, DisciplinaId, TurmaId, TrabalhoId, TipoDeAvaliacoesId")]Notas notas)
        {
            notasDAO = new NotasDAO();
            notasDAO.Editar(notas);
            return RedirectToAction("Index", "Notas");
        }

        public ActionResult ListarNotas()
        {
            IList<Notas> notas = notasDAO.ListarNotas();
            return View(notas);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Notas notas = notasDAO.BuscaPorId(id);
            return View(notas);
        }

        public ActionResult Index()
        {
            var notasDAO = new NotasDAO();
            var notas = notasDAO.ListarNotas();
            ViewBag.Notas = notas;
            return View();
        }
    }
}