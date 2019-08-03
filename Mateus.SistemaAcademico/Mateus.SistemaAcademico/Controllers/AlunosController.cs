using System.Web.Mvc;
using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;

namespace Mateus.SistemaAcademico.Controllers
{
    public class AlunosController : Controller
    {
        AlunosDAO dao = new AlunosDAO();
        // GET: Alunos
        public ActionResult Index()
        {
            //ViewBag.Alunos = alunos;

            return View(dao.ListarAlunos());
        }

        [HttpPost]
        public ActionResult Create(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                dao.Adicionar(aluno);
            }

            return View(aluno);
        }
    }
}