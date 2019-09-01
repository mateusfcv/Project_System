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
    public class FrequenciaController : Controller
    {
        // get: frequencia
        FrequenciasDAO frequenciaDAO = new FrequenciasDAO();

        [HttpPost]
        public ActionResult AdicionarFrequencia(Frequencia frequencia)
        {
            frequenciaDAO.Adicionar(frequencia);
            return RedirectToAction("Index", "Frequencia");
        }

        [HttpGet]
        public ActionResult AdicionarFrequencia()
        {
            var aluno = new AlunosDAO();
            var lista = aluno.ListarAlunos();
            ViewBag.ListarAluno = lista;

            var disciplina = new DisciplinasDAO();
            var listas = disciplina.ListarDisciplinas();
            ViewBag.ListaDisciplina = listas;

            var frequencia = new Frequencia();
            return View(frequencia);
        }

        // Remover Frequencia
        [HttpGet]
        public ActionResult RemoverFrequencia(int Id)
        {
            Frequencia frequencia = frequenciaDAO.BuscaPorId(Id);
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
            var frequenciaDAO = new FrequenciasDAO();
            Frequencia frequencia = frequenciaDAO.BuscaPorId(id);
            return View(frequencia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarFrequencia([Bind(Include = "Id, Data, DisciplinaId, AlunoId, TipoFrequencia")]Frequencia frequencia)
        {
            frequenciaDAO = new FrequenciasDAO();
            frequenciaDAO.Editar(frequencia);
            return RedirectToAction("Index", "Frequencia");
        }

        public ActionResult ListarFrequencias()
        {
            IList<Frequencia> frequencia = frequenciaDAO.ListarFrequencias();
            return View(frequencia);
        }

        public ActionResult VisualizarDetalhes(int id)
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var frequenciaDAO = new FrequenciasDAO();
            var frequencias = frequenciaDAO.ListarFrequencias();

            foreach (var frequenciaa in frequencias)
            {
                frequenciaa.Aluno = alunos.BuscaPorId(frequenciaa.AlunoId);
            }

            foreach (var frequenciaa in frequencias)
            {
                frequenciaa.Disciplina = disciplinas.BuscaPorId(frequenciaa.DisciplinaId);
            }

            Frequencia frequencia = frequenciaDAO.BuscaPorId(id);
            return View(frequencia);
        }

        public ActionResult Index()
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var frequenciaDAO = new FrequenciasDAO();
            var frequencias = frequenciaDAO.ListarFrequencias(); 

            foreach (var frequencia in frequencias)
            {
                frequencia.Aluno = alunos.BuscaPorId(frequencia.AlunoId);
            }

            foreach (var frequencia in frequencias)
            {
                frequencia.Disciplina = disciplinas.BuscaPorId(frequencia.DisciplinaId);
            }

            return View(frequencias);
        }
    }
}