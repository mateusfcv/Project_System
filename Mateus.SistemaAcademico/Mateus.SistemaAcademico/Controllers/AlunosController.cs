using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Filtro;
using Mateus.SistemaAcademico.Models;
using Mateus.SistemaAcademico.Models.Enums;
using Mateus.SistemaAcademico.Models.Objects_Value;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Mateus.SistemaAcademico.Controllers
{
    [AutorizacaoFilter]
    public class AlunosController : Controller
    {
        // get: alunos
        AlunosDAO alunosDAO = new AlunosDAO();

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpPost]
        public ActionResult AdicionarAluno(Aluno aluno)
        {
            alunosDAO.Adicionar(aluno);
            return RedirectToAction("Index", "Alunos");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpGet]
        public ActionResult AdicionarAluno()
        {
            var curso = new CursosDAO();
            var lista = curso.ListarCursos();
            ViewBag.Listacurso = lista;
            var aluno = new Aluno();
            return View(aluno);
        }

        // Remover Aluno
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpGet]
        public ActionResult RemoverAluno(int Id)
        {
            Aluno aluno = alunosDAO.BuscaPorId(Id);
            return View(aluno);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpPost]
        public ActionResult RemoverAluno(Aluno aluno)
        {
            alunosDAO.Remover(aluno);
            return RedirectToAction("Index", "Alunos");
        }

        // Editar Aluno
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpGet]
        public ActionResult EditarAluno(int id)
        {
            var alunosDAO = new AlunosDAO();
            Aluno aluno = alunosDAO.BuscaPorId(id);
            return View(aluno);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarAluno([Bind(Include = "Id, Nome, Email, Cpf, DataDeNascimento, RegistroDoAluno, ResponsavelId, CursoId")]Aluno aluno)
        {
            alunosDAO = new AlunosDAO();
            alunosDAO.Editar(aluno);

            return RedirectToAction("Index", "Alunos");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria, TipoPerfil.Professor })]
        public ActionResult ListarAluno()
        {
            IList<Aluno> alunos = alunosDAO.ListarAlunos();
            return View(alunos);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
        public ActionResult VisualizarDetalhes(int id)
        {
            var cursos = new CursosDAO();
            var alunosDAO = new AlunosDAO();
            var alunos = alunosDAO.ListarAlunos();
            foreach (var alunoss in alunos)
            {
                alunoss.Curso = cursos.BuscaPorId(alunoss.CursoId);
            }
            Aluno aluno = alunosDAO.BuscaPorId(id);
            return View(aluno);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria, TipoPerfil.Professor })]
        public ActionResult Index()
        {
            var cursos = new CursosDAO();
            var alunosDAO = new AlunosDAO();
            var alunos = alunosDAO.ListarAlunos();
            foreach (var aluno in alunos)
            {
                aluno.Curso = cursos.BuscaPorId(aluno.CursoId);
            }
            
            return View(alunos);
        }
    }
}