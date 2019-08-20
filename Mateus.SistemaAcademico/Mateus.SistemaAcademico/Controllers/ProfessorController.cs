using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mateus.SistemaAcademico.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        ProfessorDAO professorDAO = new ProfessorDAO();

        // Adicionar Professor
        [HttpGet]
        public ActionResult AdicionarProfessor()
        {
            var professor = new Professor();
            return View(professor);
        }

        [HttpPost]
        public ActionResult AdicionarProfessor(Professor professor)
        {
            professorDAO.Adicionar(professor);
            return RedirectToAction("Index", "Professor");
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
            return RedirectToAction("Index", "Professor");
        }

        // Editar Professor
        [HttpGet]
        public ActionResult EditarProfessor(int id)
        {
            var professorDAO = new ProfessorDAO();
            Professor professor = professorDAO.BuscaPorId(id);
            return View(professor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarProfessor([Bind(Include = "Id, Nome, numero, CEP, Cpf, RegistroDoProfessor, Titulacao")]
        Professor professor)
        {
            professorDAO = new ProfessorDAO();
            professorDAO.Editar(professor);
            return RedirectToAction("Index", "Professor");
        }

        // Listar Professores
        public ActionResult ListarProfessores()
        {
            IList<Professor> professors = professorDAO.ListarProfessores();
            return View(professors);
        }

        // Visualizar Detalhes
        public ActionResult VisualizarDetalhes(int id)
        {
            Professor professor = professorDAO.BuscaPorId(id);
            return View(professor);
        }

        public ActionResult Index()
        {
            var professorDAO = new ProfessorDAO();
            var professor = professorDAO.ListarProfessores();
            ViewBag.Professor = professor;
            return View();
        }
    }
}