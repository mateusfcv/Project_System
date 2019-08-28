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
    public class AvaliacoesController : Controller
    {
        // get: AVALIAÇÕES
        AvaliacoesDAO avaliacaosDAO = new AvaliacoesDAO();

        [HttpPost]
        public ActionResult AdicionarAvaliacao(Avaliacao avaliacao)
        {
            avaliacaosDAO.Adicionar(avaliacao);
            return RedirectToAction("Index", "Avaliacoes");
        }

        [HttpGet]
        public ActionResult AdicionarAvaliacao()
        {
                var avaliacao = new Avaliacao();
                return View(avaliacao);
        }

        // Remover Avaliacao
        [HttpGet]
        public ActionResult RemoverAvaliacao(int Id)
        {
            Avaliacao avaliacao = avaliacaosDAO.BuscaPorId(Id);
            return View(avaliacao);
        }

        [HttpPost]
        public ActionResult RemoverAvaliacao(Avaliacao avaliacao)
        {
            avaliacaosDAO.Remover(avaliacao);
            return RedirectToAction("Index", "Avaliacoes");
        }

        // Editar Avaliacao
        [HttpGet]
        public ActionResult EditarAvaliacao(int id)
        {
            var avaliacaosDAO = new AvaliacoesDAO();
            Avaliacao avaliacao = avaliacaosDAO.BuscaPorId(id);
            return View(avaliacao);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarAvaliacao([Bind(Include = "Id, AlunoId, Nota, DisciplinaId, Data")]Avaliacao avaliacao)
        {
            avaliacaosDAO = new AvaliacoesDAO();
            avaliacaosDAO.Editar(avaliacao);
            return RedirectToAction("Index", "Avaliacoes");
        }

        public ActionResult ListarAvaliacao()
        {
            IList<Avaliacao> avaliacaos = avaliacaosDAO.ListarAvaliacoes();
            return View(avaliacaos);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Avaliacao avaliacao = avaliacaosDAO.BuscaPorId(id);
            return View(avaliacao);
        }

        public ActionResult Index()
        {
            var avaliacaosDAO = new AvaliacoesDAO();
            var avaliacaos = avaliacaosDAO.ListarAvaliacoes();
            ViewBag.Avaliacoes = avaliacaos;
            return View();
        }
    }
}