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
    public class ConteudosController : Controller
    {
        // get: conteudos
        ConteudosDAO conteudosDAO = new ConteudosDAO();

        [HttpPost]
        public ActionResult AdicionarConteudo(Conteudo conteudo)
        {
            conteudosDAO.Adicionar(conteudo);
            return RedirectToAction("Index", "Conteudos");
        }

        [HttpGet]
        public ActionResult AdicionarConteudo()
        {
            var disciplina = new DisciplinasDAO();
            var lista = disciplina.ListarDisciplinas();
            ViewBag.ListaDisciplina = lista;
            var conteudo = new Conteudo();
            return View(conteudo);
        }

        // Remover Conteudo
        [HttpGet]
        public ActionResult RemoverConteudo(int Id)
        {
            Conteudo conteudo = conteudosDAO.BuscaPorId(Id);
            return View(conteudo);
        }

        [HttpPost]
        public ActionResult RemoverConteudo(Conteudo conteudo)
        {
            conteudosDAO.Remover(conteudo);
            return RedirectToAction("Index", "Conteudos");
        }

        // Editar Conteudo
        [HttpGet]
        public ActionResult EditarConteudo(int id)
        {
            var conteudosDAO = new ConteudosDAO();
            Conteudo conteudo = conteudosDAO.BuscaPorId(id);
            return View(conteudo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarConteudo([Bind(Include = "Id, Nome, Descricao, TipoConteudos, DisciplinaId")]Conteudo conteudo)
        {
            conteudosDAO = new ConteudosDAO();
            conteudosDAO.Editar(conteudo);
            return RedirectToAction("Index", "Conteudos");
        }

        public ActionResult ListarConteudo()
        {
            IList<Conteudo> conteudos = conteudosDAO.ListarConteudos();
            return View(conteudos);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            var disciplina = new DisciplinasDAO();
            var conteudosDAO = new ConteudosDAO();
            var conteudos = conteudosDAO.ListarConteudos();
            foreach (var conteudoo in conteudos)
            {
                conteudoo.Disciplina = disciplina.BuscaPorId(conteudoo.DisciplinaId);
            }

            Conteudo conteudo = conteudosDAO.BuscaPorId(id);
            return View(conteudo);
        }

        public ActionResult Index()
        {
            var disciplina = new DisciplinasDAO();
            var conteudosDAO = new ConteudosDAO();
            var conteudos = conteudosDAO.ListarConteudos();
            foreach (var conteudo in conteudos)
            {
                conteudo.Disciplina = disciplina.BuscaPorId(conteudo.DisciplinaId);
            }
            return View(conteudos);
        }
    }
}