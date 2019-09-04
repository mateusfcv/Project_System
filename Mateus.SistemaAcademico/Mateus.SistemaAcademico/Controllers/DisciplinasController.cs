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
    public class DisciplinasController : Controller
    {
        // get: disciplinas
        DisciplinasDAO disciplinasDAO = new DisciplinasDAO();

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Secretaria, TipoPerfil.Administrador })]
        [HttpPost]
        public ActionResult AdicionarDisciplina(Disciplina disciplina)
        {
            disciplinasDAO.Adicionar(disciplina);
            return RedirectToAction("Index", "Disciplinas");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Secretaria, TipoPerfil.Administrador })]
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
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Secretaria, TipoPerfil.Administrador })]
        [HttpGet]
        public ActionResult RemoverDisciplina(int Id)
        {
            Disciplina disciplina = disciplinasDAO.BuscaPorId(Id);
            return View(disciplina);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Secretaria, TipoPerfil.Administrador })]
        [HttpPost]
        public ActionResult RemoverDisciplina(Disciplina disciplina)
        {
            disciplinasDAO.Remover(disciplina);
            return RedirectToAction("Index", "Disciplinas");
        }

        // Editar Disciplina
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Secretaria, TipoPerfil.Administrador })]
        [HttpGet]
        public ActionResult EditarDisciplina(int id)
        {
            var disciplinasDAO = new DisciplinasDAO();
            Disciplina disciplina = disciplinasDAO.BuscaPorId(id);
            return View(disciplina);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Secretaria, TipoPerfil.Administrador })]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarDisciplina([Bind(Include = "Id, ProfessorId, Nome, CargaHoraria")]Disciplina disciplina)
        {
            disciplinasDAO = new DisciplinasDAO();
            disciplinasDAO.Editar(disciplina);
            return RedirectToAction("Index", "Disciplinas");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Secretaria, TipoPerfil.Administrador })]
        public ActionResult ListarDisciplina()
        {
            IList<Disciplina> disciplinas = disciplinasDAO.ListarDisciplinas();
            return View(disciplinas);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Secretaria, TipoPerfil.Administrador,
            TipoPerfil.Professor, TipoPerfil.Aluno })]
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

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Secretaria, TipoPerfil.Administrador,
            TipoPerfil.Professor, TipoPerfil.Aluno })]
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