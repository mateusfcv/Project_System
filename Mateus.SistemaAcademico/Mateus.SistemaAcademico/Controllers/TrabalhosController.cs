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
    public class TrabalhosController : Controller
    {
        // get: trabalhos
        TrabalhosDAO trabalhosDAO = new TrabalhosDAO();

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult AdicionarTrabalho(Trabalho trabalho)
        {
            trabalhosDAO.Adicionar(trabalho);
            return RedirectToAction("Index", "Trabalhos");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult AdicionarTrabalho()
        {
            var aluno = new AlunosDAO();
            var lista = aluno.ListarAlunos();
            ViewBag.ListarAluno = lista;

            var disciplina = new DisciplinasDAO();
            var listas = disciplina.ListarDisciplinas();
            ViewBag.ListaDisciplina = listas;

            var trabalho = new Trabalho();
            return View(trabalho);
        }

        // Remover Trabalho
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult RemoverTrabalho(int Id)
        {
            Trabalho trabalho = trabalhosDAO.BuscaPorId(Id);
            return View(trabalho);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult RemoverTrabalho(Trabalho trabalho)
        {
            trabalhosDAO.Remover(trabalho);
            return RedirectToAction("Index", "Trabalhos");
        }

        // Editar Trabalho
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult EditarTrabalho(int id)
        {
            var trabalhosDAO = new TrabalhosDAO();
            Trabalho trabalho = trabalhosDAO.BuscaPorId(id);
            return View(trabalho);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarTrabalho([Bind(Include = "Id, AlunoId, Nota, DisciplinaId, , DataDeInicio, DataDaEntrega")]Trabalho trabalho)
        {
            trabalhosDAO = new TrabalhosDAO();
            trabalhosDAO.Editar(trabalho);
            return RedirectToAction("Index", "Trabalhos");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        public ActionResult ListarTrabalho()
        {
            IList<Trabalho> trabalhos = trabalhosDAO.ListarTrabalhos();
            return View(trabalhos);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Aluno, TipoPerfil.Administrador })]
        public ActionResult VisualizarDetalhes(int id)
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var trabalhosDAO = new TrabalhosDAO();
            var trabalhos = trabalhosDAO.ListarTrabalhos();

            foreach (var trabalhoo in trabalhos)
            {
                trabalhoo.Aluno = alunos.BuscaPorId(trabalhoo.AlunoId);
            }

            foreach (var trabalhoo in trabalhos)
            {
                trabalhoo.Disciplina = disciplinas.BuscaPorId(trabalhoo.DisciplinaId);
            }

            Trabalho trabalho = trabalhosDAO.BuscaPorId(id);
            return View(trabalho);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Aluno, TipoPerfil.Administrador })]
        public ActionResult Index()
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var trabalhosDAO = new TrabalhosDAO();
            var trabalhos = trabalhosDAO.ListarTrabalhos();

            foreach (var trabalho in trabalhos)
            {
                trabalho.Aluno = alunos.BuscaPorId(trabalho.AlunoId);
            }

            foreach (var trabalho in trabalhos)
            {
                trabalho.Disciplina = disciplinas.BuscaPorId(trabalho.DisciplinaId);
            }

            return View(trabalhos);
        }
    }
}