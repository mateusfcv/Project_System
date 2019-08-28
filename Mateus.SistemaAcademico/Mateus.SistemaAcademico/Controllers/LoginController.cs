using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mateus.SistemaAcademico.Controllers
{
    public class LoginController : Controller
    {

        AlunosDAO alunosDAO = new AlunosDAO();
        ProfessoresDAO professoresDAO = new ProfessoresDAO();
        SecretariasDAO secretariasDAO = new SecretariasDAO();
        AdmDAO admDAO = new AdmDAO();

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Autentica(string login, string senha)
        {
            Aluno aluno = alunosDAO.BuscaAluno(login, senha);
            Professor professor = professoresDAO.BuscaProfessor(login, senha);
            Secretaria secretaria = secretariasDAO.BuscaSecretaria(login, senha);
            Administrador administrador = admDAO.BuscaAdm(login, senha);
           

            if (aluno != null)
            {
                Session["usuarioAlunoLogado"] = aluno;
                return RedirectToAction("Index", "Home");
            }
            else if (professor != null)
            {
                Session["usuarioProfessorLogado"] = professor;
                return RedirectToAction("Index", "Home");
            }
            else if (secretaria != null)
            {
                Session["usuarioSecretariaLogado"] = secretaria;
                return RedirectToAction("Index", "Home");
            }
            else if (administrador != null)
            {
                Session["usuarioAdministradorLogado"] = administrador;
                return RedirectToAction("Index", "Home");
            }

            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction ("Index", "Home");
        }
    }
}