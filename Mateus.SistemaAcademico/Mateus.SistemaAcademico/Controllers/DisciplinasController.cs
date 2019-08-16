using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mateus.SistemaAcademico.Controllers
{
    public class DisciplinasController : Controller
    {
        // GET: Disciplinas
        DisciplinasDAO disciplinasDAO = new DisciplinasDAO();

        // Adicionar Disciplinas
        [HttpGet]
        public ActionResult AdicionarDisciplina()
        {
            var disciplina = new Disciplina();
            return View(disciplina);
        }

        [HttpPost]
        public ActionResult AdicionarDisciplina(Disciplina disciplina)
        {
            disciplinasDAO.Adicionar(disciplina);
            return RedirectToAction("Index", "Disciplinas");
        }

        // Remover Disciplinas
        [HttpGet]
        public ActionResult RemoverDisciplina(int Id)
        {
            Disciplina disciplina = disciplinasDAO.BuscaPorId(Id);
            return View(disciplina);
        }

        [HttpPost]
        public ActionResult RemoverCurso(Disciplina disciplina)
        {
            disciplinasDAO.Remover(disciplina);
            return RedirectToAction("Index", "Disciplinas");
        }

        [HttpGet]
        public ActionResult EditarDisciplinas(int id)
        {
            Disciplina disciplina = disciplinasDAO.BuscaPorId(id);
            return View(disciplina);
        }

        // Editar Disciplinas
        [HttpPost]
        public ActionResult EditarCurso(Disciplina disciplina)
        {
            disciplinasDAO.Editar(disciplina);
            return RedirectToAction("Index", "Disciplinas");
        }

        public ActionResult ListarDisciplina()
        {
            IList<Disciplina> disciplinas = disciplinasDAO.ListarDisciplinas();
            return View(disciplinas);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Disciplina disciplina = disciplinasDAO.BuscaPorId(id);
            return View(disciplina);
        }

        public ActionResult Index()
        {
            var disciplinasDAO = new DisciplinasDAO();
            var disciplinas = disciplinasDAO.ListarDisciplinas();
            ViewBag.Disciplinas = disciplinas;
            return View();
        }
    }
}