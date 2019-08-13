using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;

namespace Mateus.SistemaAcademico.Controllers
{
    public class CursosController : Controller
    {
        // get: cursos

        // Gerar view de cadastro de curso
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
            return View(new Curso());
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

        // Listar Cursos cadastrados
        [HttpPost]
        public ActionResult ListarCurso()
        {
            var dao = new CursosDAO();
            var curso = dao.ListarCursos();
            ViewBag.Cursos = curso;
            return View();
        }

        //[HttpGet]
        //public ActionResult ListarCurso()
        //{
        //    return View(new Curso());
        //}

        public ActionResult Index()
        {
            //var dao = new CursosDAO();
            //IList<Curso> cursos = dao.ListarCursos();
            return View();
        }
    }
}