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
    public class AdmController : Controller
    {
        // get: adms
        AdmDAO admsDAO = new AdmDAO();

        [HttpPost]
        public ActionResult AdicionarAdministrador(Administrador adm)
        {
            if (ModelState.IsValid)
            {
                if (adm.ValidaData(adm))
                {
                    admsDAO.Adicionar(adm);
                    return RedirectToAction("Index", "Adm");
                }
            }
            TempData["msg"] = "Data de nascimento inválida";
            return View(adm);
            
        }

        [HttpGet]
        public ActionResult AdicionarAdministrador()
        {
                var adm = new Administrador();
                return View(adm);
        }

        // Remover Administrador
        [HttpGet]
        public ActionResult RemoverAdministrador(int Id)
        {
            Administrador adm = admsDAO.BuscaPorId(Id);
            return View(adm);
        }

        [HttpPost]
        public ActionResult RemoverAdministrador(Administrador adm)
        {
            admsDAO.Remover(adm);
            return RedirectToAction("Index", "Adm");
        }

        // Editar Administrador
        [HttpGet]
        public ActionResult EditarAdministrador(int id)
        {
            var admsDAO = new AdmDAO();
            Administrador adm = admsDAO.BuscaPorId(id);
            return View(adm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarAdministrador([Bind(Include = "Id, Nome, Email, Cpf, DataDeNascimento")]Administrador adm)
        {
            admsDAO = new AdmDAO();
            admsDAO.Editar(adm);
            return RedirectToAction("Index", "Adm");
        }

        public ActionResult ListarAdministrador()
        {
            IList<Administrador> adms = admsDAO.ListarAdm();
            return View(adms);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            Administrador adm = admsDAO.BuscaPorId(id);
            return View(adm);
        }

        public ActionResult Index()
        {
            var admsDAO = new AdmDAO();
            var adms = admsDAO.ListarAdm();
            ViewBag.Adm = adms;
            return View();
        }
    }
}