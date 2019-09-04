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
    public class CursosController : Controller
    {
        // get: cursos
        CursosDAO cursosDAO = new CursosDAO();

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
        [HttpPost]
        public ActionResult AdicionarCurso(Curso curso)
        {
            cursosDAO.Adicionar(curso);
            return RedirectToAction("Index", "Cursos");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
        [HttpGet]
        public ActionResult AdicionarCurso()
        {
            var coordenador = new ProfessoresDAO();
            var listas = coordenador.ListarProfessores();
            ViewBag.ListaCoordenador = listas;

            var secretaria = new SecretariasDAO();
            var lista = secretaria.ListarSecretarias();
            ViewBag.ListaSecretaria = lista;

            var curso = new Curso();
            curso.Coordenador = new Professor();
            return View(curso); 
        }

        // Remover Curso
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
        [HttpGet]
        public ActionResult RemoverCurso(int Id)
        {
            Curso curso = cursosDAO.BuscaPorId(Id);
            return View(curso);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
        [HttpPost]
        public ActionResult RemoverCurso(Curso curso)
        {
            cursosDAO.Remover(curso);
            return RedirectToAction("Index", "Cursos");
        }

        // Editar Curso
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
        [HttpGet]
        public ActionResult EditarCurso(int id)
        {
            var cursosDAO = new CursosDAO();
            Curso curso = cursosDAO.BuscaPorId(id);
            return View(curso);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCurso([Bind(Include = "Id, Nome, DataDeInicio, DataDeFim, CoordenadorId, SecretariaId, TipoCurso, Periodo, Area")]Curso curso)
        {
            cursosDAO = new CursosDAO();
            cursosDAO.Editar(curso);
            return RedirectToAction("Index", "Cursos");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador })]
        public ActionResult ListarCurso()
        {
            IList<Curso> cursos = cursosDAO.ListarCursos();
            return View(cursos);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria,
            TipoPerfil.Professor, TipoPerfil.Aluno })]
        public ActionResult VisualizarDetalhes(int id)
        {
            var secretaria = new SecretariasDAO();
            var cursosDAO = new CursosDAO();
            var cursos = cursosDAO.ListarCursos();
            foreach (var cursoo in cursos)
            {
                cursoo.Secretaria = secretaria.BuscaPorId(cursoo.SecretariaId);
            }

            var coordenador = new ProfessoresDAO();
            var cursoDAO = new CursosDAO();
            var cursoss = cursosDAO.ListarCursos();
            foreach (var ccurso in cursos)
            {
                ccurso.Coordenador = coordenador.BuscaPorId(ccurso.CoordenadorId);
            }

            Curso curso = cursosDAO.BuscaPorId(id);
            var alunosDAO = new AlunosDAO();
            List<Aluno> alunoCurso = alunosDAO.ListarAlunos()
                                               .Where(x => x.CursoId == id)
                                                .ToList();

            curso.Alunos = alunoCurso;
            return View(curso);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria,
            TipoPerfil.Professor, TipoPerfil.Aluno })]
        public ActionResult Index()
        {
            var cursosDAO = new CursosDAO();
            var cursos = cursosDAO.ListarCursos();
            ViewBag.Cursos = cursos;
            ViewBag.Professor = new Professor();
            return View();
        }
    }
}