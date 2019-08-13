using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mateus.SistemaAcademico.Controllers
{
    public class ResponsavelController : Controller
    {
        // GET: Responsavel
        //public ActionResult AdicionarResponsavel()
        //{

        //}

        [HttpPost]
        public ActionResult AdicionarResponsavel(Responsavel responsavel)
        {
            var dao = new ResponsavelDAO();
            dao.Adicionar(responsavel);

            return View();
         }

        public ActionResult Index()
        {
            return View();
        }
    }
}