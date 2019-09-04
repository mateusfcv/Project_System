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
    public class ExamesFinaisController : Controller
    {
        // get: exameFinals
        ExamesFinaisDAO exameFinalsDAO = new ExamesFinaisDAO();

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult AdicionarExameFinal(ExameFinal exameFinal)
        {
            exameFinalsDAO.Adicionar(exameFinal);
            return RedirectToAction("Index", "ExamesFinais");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult AdicionarExameFinal()
        {
            var aluno = new AlunosDAO();
            var lista = aluno.ListarAlunos();
            ViewBag.ListarAluno = lista;

            var disciplina = new DisciplinasDAO();
            var listas = disciplina.ListarDisciplinas();
            ViewBag.ListaDisciplina = listas;

            var exameFinal = new ExameFinal();
            return View(exameFinal);
        }

        // Remover ExameFinal
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult RemoverExameFinal(int Id)
        {
            ExameFinal exameFinal = exameFinalsDAO.BuscaPorId(Id);
            return View(exameFinal);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult RemoverExameFinal(ExameFinal exameFinal)
        {
            exameFinalsDAO.Remover(exameFinal);
            return RedirectToAction("Index", "ExamesFinais");
        }

        // Editar ExameFinal
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult EditarExameFinal(int id)
        {
            var exameFinalsDAO = new ExamesFinaisDAO();
            ExameFinal exameFinal = exameFinalsDAO.BuscaPorId(id);
            return View(exameFinal);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarExameFinal([Bind(Include = "Id, AlunoId, Nota, DisciplinaId, Data")]ExameFinal exameFinal)
        {
            exameFinalsDAO = new ExamesFinaisDAO();
            exameFinalsDAO.Editar(exameFinal);
            return RedirectToAction("Index", "ExamesFinais");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        public ActionResult ListarExameFinal()
        {
            IList<ExameFinal> exameFinals = exameFinalsDAO.ListarExamesFinais();
            return View(exameFinals);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Aluno })]
        public ActionResult VisualizarDetalhes(int id)
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var examesfinaisDAO = new ExamesFinaisDAO();
            var examesfinais = examesfinaisDAO.ListarExamesFinais();

            foreach (var examefinal in examesfinais)
            {
                examefinal.Aluno = alunos.BuscaPorId(examefinal.AlunoId);
            }

            foreach (var examefinal in examesfinais)
            {
                examefinal.Disciplina = disciplinas.BuscaPorId(examefinal.DisciplinaId);
            }

            ExameFinal exameFinal = exameFinalsDAO.BuscaPorId(id);
            return View(exameFinal);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Aluno })]
        public ActionResult Index()
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var examesfinaisDAO = new ExamesFinaisDAO();
            var examesfinais = examesfinaisDAO.ListarExamesFinais();

            foreach (var examefinal in examesfinais)
            {
                examefinal.Aluno = alunos.BuscaPorId(examefinal.AlunoId);
            }

            foreach (var examefinal in examesfinais)
            {
                examefinal.Disciplina = disciplinas.BuscaPorId(examefinal.DisciplinaId);
            }

            return View(examesfinais);
        }
    }
}