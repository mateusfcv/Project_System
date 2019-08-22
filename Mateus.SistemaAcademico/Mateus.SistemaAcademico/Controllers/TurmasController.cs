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
    public class TurmasController : Controller
    {
        // get: turmas
        TurmasDAO turmasDAO = new TurmasDAO();

        [HttpPost]
        public ActionResult AdicionarTurma(Turma turma)
        {
            turmasDAO.Adicionar(turma);
            return RedirectToAction("Index", "Turmas");
        }

        [HttpGet]
        public ActionResult AdicionarTurma()
        {
                var turma = new Turma();
                return View(turma);
        }

        // Remover Turma
        [HttpGet]
        public ActionResult RemoverTurma(int Id)
        {
            Turma turma = turmasDAO.BuscaPorId(Id);
            return View(turma);
        }

        [HttpPost]
        public ActionResult RemoverTurma(Turma turma)
        {
            turmasDAO.Remover(turma);
            return RedirectToAction("Index", "Turmas");
        }

        // Editar Turma
        [HttpGet]
        public ActionResult EditarTurma(int id)
        {
            var turmasDAO = new TurmasDAO();
            Turma turma = turmasDAO.BuscaPorId(id);
            return View(turma);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarTurma([Bind(Include = "Id, Nome, AlunoId, DisciplinaId, Ano")]Turma turma)
        {
            turmasDAO = new TurmasDAO();
            turmasDAO.Editar(turma);
            return RedirectToAction("Index", "Turmas");
        }

        public ActionResult ListarTurma()
        {
            IList<Turma> turmas = turmasDAO.ListarTurmas();
            return View(turmas);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Turma turma = turmasDAO.BuscaPorId(id);
            return View(turma);
        }

        public ActionResult Index()
        {
            var turmasDAO = new TurmasDAO();
            var turmas = turmasDAO.ListarTurmas();
            ViewBag.Turmas = turmas;
            return View();
        }
    }
}