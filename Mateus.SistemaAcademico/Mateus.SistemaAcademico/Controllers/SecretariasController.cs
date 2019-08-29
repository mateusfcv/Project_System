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
    public class SecretariasController : Controller
    {
        // get: secretarias
        SecretariasDAO secretariasDAO = new SecretariasDAO();

        [HttpPost]
        public ActionResult AdicionarSecretaria(Secretaria secretaria)
        {
            secretariasDAO.Adicionar(secretaria);
            return RedirectToAction("Index", "Secretarias");
        }

        [HttpGet]
        public ActionResult AdicionarSecretaria()
        {
                var secretaria = new Secretaria();
                return View(secretaria);
        }

        // Remover Secretaria
        [HttpGet]
        public ActionResult RemoverSecretaria(int Id)
        {
            Secretaria secretaria = secretariasDAO.BuscaPorId(Id);
            return View(secretaria);
        }

        [HttpPost]
        public ActionResult RemoverSecretaria(Secretaria secretaria)
        {
            secretariasDAO.Remover(secretaria);
            return RedirectToAction("Index", "Secretarias");
        }

        // Editar Secretaria
        [HttpGet]
        public ActionResult EditarSecretaria(int id)
        {
            var secretariasDAO = new SecretariasDAO();
            Secretaria secretaria = secretariasDAO.BuscaPorId(id);
            return View(secretaria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarSecretaria([Bind(Include = "Id, Nome, Email, Cpf, DataDeNascimento")]Secretaria secretaria)
        {
            secretariasDAO = new SecretariasDAO();
            secretariasDAO.Editar(secretaria);
            return RedirectToAction("Index", "Secretarias");
        }

        public ActionResult ListarSecretaria()
        {
            IList<Secretaria> secretarias = secretariasDAO.ListarSecretarias();
            return View(secretarias);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Secretaria secretaria = secretariasDAO.BuscaPorId(id);
            var cursosDAO = new CursosDAO();
            List<Curso> secretariaCurso = cursosDAO.ListarCursos()
                                                    .Where(x => x.SecretariaId == id)
                                                     .ToList();
            secretaria.Cursos = secretariaCurso;
            return View(secretaria);
        }

        public ActionResult Index()
        {
            var secretariasDAO = new SecretariasDAO();
            var secretarias = secretariasDAO.ListarSecretarias();
            ViewBag.Secretarias = secretarias;
            return View();
        }
    }
}