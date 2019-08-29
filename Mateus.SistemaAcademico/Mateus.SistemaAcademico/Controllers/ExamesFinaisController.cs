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
    public class ExamesFinaisController : Controller
    {
        // get: exameFinals
        ExamesFinaisDAO exameFinalsDAO = new ExamesFinaisDAO();

        [HttpPost]
        public ActionResult AdicionarExameFinal(ExameFinal exameFinal)
        {
            exameFinalsDAO.Adicionar(exameFinal);
            return RedirectToAction("Index", "ExamesFinais");
        }

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
        [HttpGet]
        public ActionResult RemoverExameFinal(int Id)
        {
            ExameFinal exameFinal = exameFinalsDAO.BuscaPorId(Id);
            return View(exameFinal);
        }

        [HttpPost]
        public ActionResult RemoverExameFinal(ExameFinal exameFinal)
        {
            exameFinalsDAO.Remover(exameFinal);
            return RedirectToAction("Index", "ExamesFinais");
        }

        // Editar ExameFinal
        [HttpGet]
        public ActionResult EditarExameFinal(int id)
        {
            var exameFinalsDAO = new ExamesFinaisDAO();
            ExameFinal exameFinal = exameFinalsDAO.BuscaPorId(id);
            return View(exameFinal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarExameFinal([Bind(Include = "Id, AlunoId, Nota, DisciplinaId, Data")]ExameFinal exameFinal)
        {
            exameFinalsDAO = new ExamesFinaisDAO();
            exameFinalsDAO.Editar(exameFinal);
            return RedirectToAction("Index", "ExamesFinais");
        }

        public ActionResult ListarExameFinal()
        {
            IList<ExameFinal> exameFinals = exameFinalsDAO.ListarExamesFinais();
            return View(exameFinals);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            ExameFinal exameFinal = exameFinalsDAO.BuscaPorId(id);
            return View(exameFinal);
        }

        public ActionResult Index()
        {
            var exameFinalsDAO = new ExamesFinaisDAO();
            var exameFinals = exameFinalsDAO.ListarExamesFinais();
            ViewBag.ExamesFinais = exameFinals;
            return View();
        }
    }
}