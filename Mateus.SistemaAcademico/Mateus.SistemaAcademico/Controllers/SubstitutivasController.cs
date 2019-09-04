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
    public class SubstitutivasController : Controller
    {
        // get: substitutivas
        SubstitutivasDAO substitutivasDAO = new SubstitutivasDAO();

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult AdicionarSubstitutivas(Substitutivas substitutivas)
        {
            substitutivasDAO.Adicionar(substitutivas);
            return RedirectToAction("Index", "Substitutivas");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
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
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult RemoverSubstitutivas(int Id)
        {
            Substitutivas substitutivas = substitutivasDAO.BuscaPorId(Id);
            return View(substitutivas);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult RemoverSubstitutivas(Substitutivas substitutivas)
        {
            substitutivasDAO.Remover(substitutivas);
            return RedirectToAction("Index", "Substitutivas");
        }

        // Editar Substitutivas
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult EditarSubstitutivas(int id)
        {
            var substitutivasDAO = new SubstitutivasDAO();
            Substitutivas substitutivas = substitutivasDAO.BuscaPorId(id);
            return View(substitutivas);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarSubstitutivas([Bind(Include = "Id, AlunoId, Nota, DisciplinaId, Data")]Substitutivas substitutivas)
        {
            substitutivasDAO = new SubstitutivasDAO();
            substitutivasDAO.Editar(substitutivas);
            return RedirectToAction("Index", "Substitutivas");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        public ActionResult ListarSubstitutivas()
        {
            IList<Substitutivas> substitutivas = substitutivasDAO.ListarSubstitutivas();
            return View(substitutivas);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Administrador, TipoPerfil.Aluno })]
        public ActionResult VisualizarDetalhes(int id)
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var substitutivasDAO = new SubstitutivasDAO(); 
            var substitutivass = substitutivasDAO.ListarSubstitutivas();

            foreach (var substitutiva in substitutivass)
            {
                substitutiva.Aluno = alunos.BuscaPorId(substitutiva.AlunoId);
            }

            foreach (var substitutiva in substitutivass)
            {
                substitutiva.Disciplina = disciplinas.BuscaPorId(substitutiva.DisciplinaId);
            }

            Substitutivas substitutivas = substitutivasDAO.BuscaPorId(id);
            return View(substitutivas);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Administrador, TipoPerfil.Aluno })]
        public ActionResult Index()
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var substitutivasDAO = new SubstitutivasDAO();
            var substitutivas = substitutivasDAO.ListarSubstitutivas();

            foreach (var substitutiva in substitutivas)
            {
                substitutiva.Aluno = alunos.BuscaPorId(substitutiva.AlunoId);
            }

            foreach (var substitutiva in substitutivas)
            {
                substitutiva.Disciplina = disciplinas.BuscaPorId(substitutiva.DisciplinaId);
            }

            return View(substitutivas);
        }
    }
}