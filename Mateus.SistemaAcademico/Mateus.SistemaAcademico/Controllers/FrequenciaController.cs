using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mateus.SistemaAcademico.Controllers
{
    public class FrequenciaController : Controller
    {
        // GET: Frequencia

        FrequenciaDAO frequenciaDAO = new FrequenciaDAO();

        // Adicionar Frequencia
        [HttpGet]
        public ActionResult AdicionarFrequencia()
        {
            var frequencia = new Frequencia();
            return View(frequencia);
        }

        [HttpPost]
        public ActionResult AdicionarFrequencia(Frequencia frequencia)
        {
            frequenciaDAO.Adicionar(frequencia);
            return RedirectToAction("Index", "Frequencia");
        }

        // Remover Frequencia
        [HttpGet]
        public ActionResult RemoverFrequencia(int id)
        {
            Frequencia frequencia = frequenciaDAO.BuscaPorId(id);
            return View(frequencia);
        }

        [HttpPost]
        public ActionResult RemoverFrequencia(Frequencia frequencia)
        {
            frequenciaDAO.Remover(frequencia);
            return RedirectToAction("Index", "Frequencia");
        }

        // Editar Frequencia
        [HttpGet]
        public ActionResult EditarFrequencia(int id)
        {
            var frequenciaDAO = new FrequenciaDAO();
            Frequencia frequencia = frequenciaDAO.BuscaPorId(id);
            return View(frequencia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarFrequencia([Bind(Include ="Id, TipoFrequencia, Data, DisciplinaId, AlunoId")]Frequencia frequencia)
        {
            frequenciaDAO = new FrequenciaDAO();
            frequenciaDAO.Editar(frequencia);
            return RedirectToAction("Index", "Frenquencia");
        }

        // Listar Frequencia
        public ActionResult ListarFrequencia()
        {
            IList<Frequencia> frequencias = frequenciaDAO.ListarFrequencias();
            return View(frequencias);
        }

        // Visualizar Frequencia
        public ActionResult VisualizarDetalhes(int id)
        {
            Frequencia frequencia = frequenciaDAO.BuscaPorId(id);
            return View(frequencia);
        }

        public ActionResult Index()
        {
            var frequenciaDAO = new FrequenciaDAO();
            var frequencias = frequenciaDAO.ListarFrequencias();
            ViewBag.Frequencias = frequencias;
            return View();
        }
    }
}