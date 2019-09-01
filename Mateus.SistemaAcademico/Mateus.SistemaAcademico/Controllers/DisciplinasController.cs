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
    public class DisciplinasController : Controller
    {
        // get: disciplinas
        DisciplinasDAO disciplinasDAO = new DisciplinasDAO();

        [HttpPost]
        public ActionResult AdicionarDisciplina(Disciplina disciplina)
        {
            disciplinasDAO.Adicionar(disciplina);
            return RedirectToAction("Index", "Disciplinas");
        }

        [HttpGet]
        public ActionResult AdicionarDisciplina()
        {
            var professor = new ProfessoresDAO();
            IList<Professor> lista = professor.ListarProfessores();
            ViewBag.listaProfessor = lista;

            var disciplina = new Disciplina();
            return View(disciplina);
        }

        // Remover Disciplina
        [HttpGet]
        public ActionResult RemoverDisciplina(int Id)
        {
            Disciplina disciplina = disciplinasDAO.BuscaPorId(Id);
            return View(disciplina);
        }

        [HttpPost]
        public ActionResult RemoverDisciplina(Disciplina disciplina)
        {
            disciplinasDAO.Remover(disciplina);
            return RedirectToAction("Index", "Disciplinas");
        }

        // Editar Disciplina
        [HttpGet]
        public ActionResult EditarDisciplina(int id)
        {
            var disciplinasDAO = new DisciplinasDAO();
            Disciplina disciplina = disciplinasDAO.BuscaPorId(id);
            return View(disciplina);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarDisciplina([Bind(Include = "Id, ProfessorId, Nome, CargaHoraria")]Disciplina disciplina)
        {
            disciplinasDAO = new DisciplinasDAO();
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
            var professor = new ProfessoresDAO();
            var disciplinasDAO = new DisciplinasDAO();
            var disciplinas = disciplinasDAO.ListarDisciplinas();
            foreach (var disciplinass in disciplinas)
            {
                disciplinass.Professor = professor.BuscaPorId(disciplinass.ProfessorId);
            }

            Disciplina disciplina = disciplinasDAO.BuscaPorId(id);
            return View(disciplina);
        }

        public ActionResult Index()
        {
            var professor = new ProfessoresDAO();
            var disciplinasDAO = new DisciplinasDAO();
            var disciplinas = disciplinasDAO.ListarDisciplinas();
            foreach (var disciplina in disciplinas)
            {
                disciplina.Professor = professor.BuscaPorId(disciplina.ProfessorId);
            }
            return View(disciplinas);
        }
    }
}