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

        [HttpPost]
        public ActionResult AdicionarCurso(Curso curso)
        {
            var dao = new CursosDAO();
            dao.Adicionar(curso);
            return View();
        }

        [HttpGet]
        public ActionResult AdicionarCurso()
        {
            var curso = new Curso();
            curso.Coordenador = new Professor();
            return View(curso);
        }

        // Remover Curso
        [HttpPost]
        public ActionResult RemoverCurso(Curso curso)
        {
            var dao = new CursosDAO();
            dao.Remover(curso);
            return View();
        }

        [HttpGet]
        public ActionResult RemoverCurso()
        {
            return View(new Curso());
        }

        // Editar Curso
        [HttpPost]
        public ActionResult EditarCurso(Curso curso)
        {
            var dao = new CursosDAO();
            dao.Editar(curso);
            return View();
        }

        [HttpGet]
        public ActionResult EditarCurso()
        {
            return View(new Curso());
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