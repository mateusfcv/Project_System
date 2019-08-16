using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

            cursosDAO.Adicionar(curso);
            return RedirectToAction("Index", "Cursos");
        }

        [HttpGet]
        public ActionResult AdicionarCurso()
        {
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
            Curso curso = cursosDAO.BuscaPorId(id);
            return View(curso);
        }

        // FAZER A VALIDAÇÃO DO CAMPO NOME E CRIAR FUNÇÃO PARA EXIBIR O NOME DO COORDENADOR
        [HttpPost]
        public ActionResult EditarCurso(Curso curso)
        {
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