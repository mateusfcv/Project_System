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
    public class ProfessoresController : Controller
    {
        // get: professor
        ProfessoresDAO professorDAO = new ProfessoresDAO();

        [HttpPost]
        public ActionResult AdicionarProfessor(Professor professor)
        {
            professorDAO.Adicionar(professor);
            return RedirectToAction("Index", "Professores");
        }

        [HttpGet]
        public ActionResult AdicionarProfessor()
        {
                var professor = new Professor();
                return View(professor);
        }

        // Remover Professor
        [HttpGet]
        public ActionResult RemoverProfessor(int id)
        {
            Professor professor = professorDAO.BuscaPorId(id);
            return View(professor);
        }

        [HttpPost]
        public ActionResult RemoverProfessor(Professor professor)
        {
            professorDAO.Remover(professor);
            return RedirectToAction("Index", "Professores");
        }

        // Editar Professor
        [HttpGet]
        public ActionResult EditarProfessor(int id)
        {
            var professorDAO = new ProfessoresDAO();
            Professor professor = professorDAO.BuscaPorId(id);
            return View(professor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarProfessor([Bind(Include = "Id, Nome, Email, Cpf, DataDeNascimento, RegistroDoProfessor, Titulacao")]Professor professor)
        {
            professorDAO = new ProfessoresDAO();
            professorDAO.Editar(professor);
            return RedirectToAction("Index", "Professores");
        }

        public ActionResult ListarProfessores()
        {
            IList<Professor> professor = professorDAO.ListarProfessores();
            return View(professor);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Professor professor = professorDAO.BuscaPorId(id);
            var disciplinaDAO = new DisciplinasDAO();
            List<Disciplina> disciplinaProfessor = disciplinaDAO.ListarDisciplinas()
                                                                .Where(x => x.ProfessorId == id)
                                                                .ToList();
            professor.Disciplinas = disciplinaProfessor;
            return View(professor);
        }

        public ActionResult Index()
        {
            var professorDAO = new ProfessoresDAO();
            // trocar o var para o ususario de professor
            var User = (Professor)Session["ProfessorLogado"];
            var professor = professorDAO.ListarProfessores();
            ViewBag.Professor = professor;

            return View();
        }
    }
}