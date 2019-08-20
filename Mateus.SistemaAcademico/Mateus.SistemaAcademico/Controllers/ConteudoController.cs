using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mateus.SistemaAcademico.Controllers
{
    public class ConteudoController : Controller
    {
        // GET: Conteudo
        ConteudosDAO conteudoDAO = new ConteudosDAO();

        // Adicionar Conteudo
        [HttpGet]
        public ActionResult AdicionarConteudo()
        {
            var conteudo = new Conteudo();
            return View(conteudo);
        }

        [HttpPost]
        public ActionResult AdicionarConteudo(Conteudo conteudo)
        {
            // IMPLEMENTAR A VALIDAÇÃO DE NOME, EXISTENTE NA CLASSE CURSO E CRIAR FUNÇÃO PARA EXIBIR O NOME DO COORDENADOR
            conteudoDAO.Adicionar(conteudo);
            return RedirectToAction("Index", "Conteudos");
        }

        // Remover Conteudo
        [HttpGet]
        public ActionResult RemoverConteudo(int Id)
        {
            Conteudo conteudo = conteudoDAO.BuscaPorId(Id);
            return View(conteudo);
        }

        [HttpPost]
        public ActionResult RemoverConteudo(Conteudo conteudo)
        {
            conteudoDAO.Remover(conteudo);
            return RedirectToAction("Index", "Conteudo");
        }

        // Editar Conteudo
        [HttpGet]
        public ActionResult EditarConteudo(int id)
        {
            var conteudoDAO = new ConteudosDAO();
            Conteudo conteudo = conteudoDAO.BuscaPorId(id);
            return View(conteudo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCurso([Bind(Include = "Id, Decrivao, TipoConteudo")]Conteudo conteudo)
        {
            conteudoDAO = new ConteudosDAO();
            conteudoDAO.Editar(conteudo);
            return RedirectToAction("Index", "Conteudo");
        }

        public ActionResult ListarConteudo()
        {
            IList<Conteudo> conteudos = conteudoDAO.ListarConteudos();
            return View(conteudos);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Conteudo conteudo = conteudoDAO.BuscaPorId(id);
            return View(conteudo);
        }

        public ActionResult Index()
        {
            var conteudoDAO = new ConteudosDAO();
            var conteudo = conteudoDAO.ListarConteudos();
            ViewBag.Conteudos = conteudo;
            return View();
        }
    }
}