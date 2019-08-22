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
    public class TipoDeAvaliacoesController : Controller
    {
        // get: tipoDeAvaliacoes
        TipoDeAvaliacoesDAO tipoDeAvaliacoesDAO = new TipoDeAvaliacoesDAO();

        [HttpPost]
        public ActionResult AdicionarTipoDeAvaliacoes(TipoDeAvaliacoes tipoDeAvaliacoes)
        {
            tipoDeAvaliacoesDAO.Adicionar(tipoDeAvaliacoes);
            return RedirectToAction("Index", "TipoDeAvaliacoes");
        }

        [HttpGet]
        public ActionResult AdicionarTipoDeAvaliacoes()
        {
                var tipoDeAvaliacoes = new TipoDeAvaliacoes();
                return View(tipoDeAvaliacoes);
        }

        // Remover TipoDeAvaliacoes
        [HttpGet]
        public ActionResult RemoverTipoDeAvaliacoes(int Id)
        {
            TipoDeAvaliacoes tipoDeAvaliacoes = tipoDeAvaliacoesDAO.BuscaPorId(Id);
            return View(tipoDeAvaliacoes);
        }

        [HttpPost]
        public ActionResult RemoverTipoDeAvaliacoes(TipoDeAvaliacoes tipoDeAvaliacoes)
        {
            tipoDeAvaliacoesDAO.Remover(tipoDeAvaliacoes);
            return RedirectToAction("Index", "TipoDeAvaliacoes");
        }

        // Editar TipoDeAvaliacoes
        [HttpGet]
        public ActionResult EditarTipoDeAvaliacoes(int id)
        {
            var tipoDeAvaliacoesDAO = new TipoDeAvaliacoesDAO();
            TipoDeAvaliacoes tipoDeAvaliacoes = tipoDeAvaliacoesDAO.BuscaPorId(id);
            return View(tipoDeAvaliacoes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarTipoDeAvaliacoes([Bind(Include = "Id, DataAvaliacao, NotaAvaliacoes, NotaSubstitutivas, NotaExameFinal")]TipoDeAvaliacoes tipoDeAvaliacoes)
        {
            tipoDeAvaliacoesDAO = new TipoDeAvaliacoesDAO();
            tipoDeAvaliacoesDAO.Editar(tipoDeAvaliacoes);
            return RedirectToAction("Index", "TipoDeAvaliacoes");
        }

        public ActionResult ListarTipoDeAvaliacoes()
        {
            IList<TipoDeAvaliacoes> tipoDeAvaliacoes = tipoDeAvaliacoesDAO.ListarTipoDeAvaliacoes();
            return View(tipoDeAvaliacoes);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            TipoDeAvaliacoes tipoDeAvaliacoes = tipoDeAvaliacoesDAO.BuscaPorId(id);
            return View(tipoDeAvaliacoes);
        }

        public ActionResult Index()
        {
            var tipoDeAvaliacoesDAO = new TipoDeAvaliacoesDAO();
            var tipoDeAvaliacoes = tipoDeAvaliacoesDAO.ListarTipoDeAvaliacoes();
            ViewBag.TipoDeAvaliacoes = tipoDeAvaliacoes;
            return View();
        }
    }
}