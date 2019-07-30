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
        // GET: Alunos
        public ActionResult Index()
        {
            AlunosDAO dao = new AlunosDAO();
            IList<Aluno> alunos = dao.ListarAlunos();
            ViewBag.Alunos = alunos;

            return View();
        }
    }
}