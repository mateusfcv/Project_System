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
    public class SubstitutivasController : Controller
    {
        // get: substitutivas
        SubstitutivasDAO substitutivasDAO = new SubstitutivasDAO();

        [HttpPost]
        public ActionResult AdicionarSubstitutivas(Substitutivas substitutivas)
        {
            substitutivasDAO.Adicionar(substitutivas);
            return RedirectToAction("Index", "Substitutivas");
        }

        [HttpGet]
        public ActionResult AdicionarSubstitutivas()
        {
            var aluno = new AlunosDAO();
            var lista = aluno.ListarAlunos();
            ViewBag.ListarAluno = lista;

            var disciplina = new DisciplinasDAO();
            var listas = disciplina.ListarDisciplinas();
            ViewBag.ListaDisciplina = listas;

            var substitutivas = new Substitutivas();
            return View(substitutivas);
        }

        // Remover Substitutivas
        [HttpGet]
        public ActionResult RemoverSubstitutivas(int Id)
        {
            Substitutivas substitutivas = substitutivasDAO.BuscaPorId(Id);
            return View(substitutivas);
        }

        [HttpPost]
        public ActionResult RemoverSubstitutivas(Substitutivas substitutivas)
        {
            substitutivasDAO.Remover(substitutivas);
            return RedirectToAction("Index", "Substitutivas");
        }

        // Editar Substitutivas
        [HttpGet]
        public ActionResult EditarSubstitutivas(int id)
        {
            var substitutivasDAO = new SubstitutivasDAO();
            Substitutivas substitutivas = substitutivasDAO.BuscaPorId(id);
            return View(substitutivas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarSubstitutivas([Bind(Include = "Id, AlunoId, Nota, DisciplinaId, Data")]Substitutivas substitutivas)
        {
            substitutivasDAO = new SubstitutivasDAO();
            substitutivasDAO.Editar(substitutivas);
            return RedirectToAction("Index", "Substitutivas");
        }

        public ActionResult ListarSubstitutivas()
        {
            IList<Substitutivas> substitutivas = substitutivasDAO.ListarSubstitutivas();
            return View(substitutivas);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Substitutivas substitutivas = substitutivasDAO.BuscaPorId(id);
            return View(substitutivas);
        }

        public ActionResult Index()
        {
            var substitutivasDAO = new SubstitutivasDAO();
            var substitutivas = substitutivasDAO.ListarSubstitutivas();
            ViewBag.Substitutivas = substitutivas;
            return View();
        }
    }
}