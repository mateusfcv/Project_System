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
    [AutorizacaoFilter]
    public class NotasController : Controller
    {
        // get: notas
        NotasDAO notasDAO = new NotasDAO();

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult AdicionarNota(Nota nota)
        {
            notasDAO.Adicionar(nota);
            return RedirectToAction("Index", "Notas");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult AdicionarNota()
        {
                var nota = new Nota();
                return View(nota);
        }

        // Remover Nota
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult RemoverNota(int Id)
        {
            Nota nota = notasDAO.BuscaPorId(Id);
            return View(nota);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult RemoverNota(Nota nota)
        {
            notasDAO.Remover(nota);
            return RedirectToAction("Index", "Notas");
        }

        // Editar Nota
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult EditarNota(int id)
        {
            var notasDAO = new NotasDAO();
            Nota nota = notasDAO.BuscaPorId(id);
            return View(nota);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarNota([Bind(Include = "Id, DisciplinaId, Substitutivas, Trabalho, Avaliacao, AlunoId")]Nota nota)
        {
            notasDAO = new NotasDAO();
            notasDAO.Editar(nota);
            return RedirectToAction("Index", "Notas");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        public ActionResult ListarNota()
        {
            IList<Nota> notas = notasDAO.ListarNotas();
            return View(notas);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Aluno })]
        public ActionResult VisualizarDetalhes(int id)
        {
            Nota nota = notasDAO.BuscaPorId(id);
            return View(nota);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Aluno })]
        public ActionResult Index()
        {
            var notasDAO = new NotasDAO();
            var notas = notasDAO.ListarNotas();
            ViewBag.Notas = notas;
            return View();
        }
    }
}