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
        public ActionResult AdicionarNota(Nota nota)
        {
            notasDAO.Adicionar(nota);
            return RedirectToAction("Index", "Notas");
        }

        [HttpGet]
        public ActionResult AdicionarNota()
        {
                var nota = new Nota();
                return View(nota);
        }

        // Remover Nota
        [HttpGet]
        public ActionResult RemoverNota(int Id)
        {
            Nota nota = notasDAO.BuscaPorId(Id);
            return View(nota);
        }

        [HttpPost]
        public ActionResult RemoverNota(Nota nota)
        {
            notasDAO.Remover(nota);
            return RedirectToAction("Index", "Notas");
        }

        // Editar Nota
        [HttpGet]
        public ActionResult EditarNota(int id)
        {
            var notasDAO = new NotasDAO();
            Nota nota = notasDAO.BuscaPorId(id);
            return View(nota);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarNota([Bind(Include = "Id, DisciplinaId, Substitutivas, Trabalho, Avaliacao, AlunoId")]Nota nota)
        {
            notasDAO = new NotasDAO();
            notasDAO.Editar(nota);
            return RedirectToAction("Index", "Notas");
        }

        public ActionResult ListarNota()
        {
            IList<Nota> notas = notasDAO.ListarNotas();
            return View(notas);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Nota nota = notasDAO.BuscaPorId(id);
            return View(nota);
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