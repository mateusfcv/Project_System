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
    public class CursosController : Controller
    {
        // get: cursos
        CursosDAO cursosDAO = new CursosDAO();

        [HttpPost]
        public ActionResult AdicionarCurso(Curso curso)
        {
            // IMPLEMENTAR A VALIDAÇÃO DE NOME, EXISTENTE NA CLASSE CURSO E CRIAR FUNÇÃO PARA EXIBIR O NOME DO COORDENADOR
            cursosDAO.Adicionar(curso);
            return RedirectToAction("Index", "Cursos");
        }

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
        [HttpGet]
        public ActionResult RemoverCurso(int Id)
        {
            Curso curso = cursosDAO.BuscaPorId(Id);
            return View(curso);
        }

        [HttpPost]
        public ActionResult RemoverCurso(Curso curso)
        {
            cursosDAO.Remover(curso);
            return RedirectToAction("Index", "Cursos");
        }

        // Editar Curso
        [HttpGet]
        public ActionResult EditarCurso(int id)
        {
            var cursosDAO = new CursosDAO();
            Curso curso = cursosDAO.BuscaPorId(id);
            return View(curso);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCurso([Bind(Include = "Id, Nome, DataDeInicio, DataDeFim, CoordenadorId, SecretariaId, TipoCurso, Periodo, Area")]Curso curso)
        {
            cursosDAO = new CursosDAO();
            cursosDAO.Editar(curso);
            return RedirectToAction("Index", "Cursos");
        }

        public ActionResult ListarCurso()
        {
            IList<Curso> cursos = cursosDAO.ListarCursos();
            return View(cursos);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Curso curso = cursosDAO.BuscaPorId(id);
            return View(curso);
        }

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