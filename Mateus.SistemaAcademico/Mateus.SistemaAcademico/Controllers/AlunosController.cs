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
    public class AlunosController : Controller
    {
        // get: alunos
        AlunosDAO alunosDAO = new AlunosDAO();

        [HttpPost]
        public ActionResult AdicionarAluno(Aluno aluno)
        {
            alunosDAO.Adicionar(aluno);
            return RedirectToAction("Index", "Alunos");
        }

        [HttpGet]
        public ActionResult AdicionarAluno()
        {
                var aluno = new Aluno();
                return View(aluno);
        }

        // Remover Aluno
        [HttpGet]
        public ActionResult RemoverAluno(int Id)
        {
            Aluno aluno = alunosDAO.BuscaPorId(Id);
            return View(aluno);
        }

        [HttpPost]
        public ActionResult RemoverAluno(Aluno aluno)
        {
            alunosDAO.Remover(aluno);
            return RedirectToAction("Index", "Alunos");
        }

        // Editar Aluno
        [HttpGet]
        public ActionResult EditarAluno(int id)
        {
            var alunosDAO = new AlunosDAO();
            Aluno aluno = alunosDAO.BuscaPorId(id);
            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarAluno([Bind(Include = "Id, Nome, Email, Cpf, DataDeNascimento, RegistroDoAluno, ResponsavelId, CursoId")]Aluno aluno)
        {
            alunosDAO = new AlunosDAO();
            alunosDAO.Editar(aluno);
            return RedirectToAction("Index", "Alunos");
        }

        public ActionResult ListarAluno()
        {
            IList<Aluno> alunos = alunosDAO.ListarAlunos();
            return View(alunos);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Aluno aluno = alunosDAO.BuscaPorId(id);
            return View(aluno);
        }

        public ActionResult Index()
        {
            var alunosDAO = new AlunosDAO();
            var alunos = alunosDAO.ListarAlunos();
            ViewBag.Alunos = alunos;
            return View();
        }
    }
}