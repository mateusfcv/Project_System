using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;

namespace Mateus.SistemaAcademico.Controllers
{
    public class AlunosController : Controller
    {
        // get: alunos
        [HttpPost]
        public ActionResult AdicionarAluno(Aluno aluno)
        {
            var dao = new AlunosDAO();
            dao.Adicionar(aluno);
            return View();
        }

        [HttpGet]
        public ActionResult AdicionarAluno()
        {
            return View(new Aluno());
        }

        public ActionResult RemoverAluno(Aluno aluno)
        {
            var dao = new AlunosDAO();
            dao.Remover(aluno);
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}