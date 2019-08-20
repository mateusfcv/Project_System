using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mateus.SistemaAcademico.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        AlunoDAO alunoDAO = new AlunoDAO();

        // Adicionar Aluno
        [HttpGet]
        public ActionResult AdicionarAluno()
        {
            var aluno = new Aluno();
            return View(aluno);
        }

        [HttpPost]
        public ActionResult AdicionarAluno(Aluno aluno)
        {
            alunoDAO.Adicionar(aluno);
            return RedirectToAction("Index", "Aluno");
        }

        // Remover Aluno
        [HttpGet]
        public ActionResult RemoverAluno(int id)
        {
            Aluno aluno = alunoDAO.BuscaPorId(id);
            return View(aluno);
        }

        [HttpPost]
        public ActionResult RemoverAluno(Aluno aluno)
        {
            alunoDAO.Remover(aluno);
            return RedirectToAction("Index", "Aluno");
        }

        // Editar Aluno
        [HttpGet]
        public ActionResult EditarAluno(int id)
        {
            var alunoDAO = new AlunoDAO();
            Aluno aluno = alunoDAO.BuscaPorId(id);
            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarAluno([Bind(Include = "Id, Nome, Cpf, RegistroDoAluno, Responsaveis, Curso")]
        Aluno aluno)
        {
            alunoDAO = new AlunoDAO();
            alunoDAO.Editar(aluno);
            return RedirectToAction("Index", "Aluno");
        }

        // Listar Alunos
        public ActionResult ListarAlunos()
        {
            IList<Aluno> alunos = alunoDAO.ListarAlunos();
            return View(alunos);
        }

        // Visualizar Detalhes
        public ActionResult VisualizarDetalhes(int id)
        {
            Aluno aluno = alunoDAO.BuscaPorId(id);
            return View(aluno);
        }

        public ActionResult Index()
        {
            var alunoDAO = new AlunoDAO();
            var aluno = alunoDAO.ListarAlunos();
            ViewBag.Aluno = aluno;
            return View();
        }
    }
}