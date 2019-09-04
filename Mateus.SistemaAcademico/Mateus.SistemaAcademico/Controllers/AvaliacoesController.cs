﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mateus.SistemaAcademico.Bussines;
using Mateus.SistemaAcademico.DAO;
using Mateus.SistemaAcademico.Filtro;
using Mateus.SistemaAcademico.Models;
using Mateus.SistemaAcademico.Models.Enums;

namespace Mateus.SistemaAcademico.Controllers
{
    [AutorizacaoFilter]
    public class AvaliacoesController : Controller
    {
        // get: AVALIAÇÕES
        AvaliacoesDAO avaliacaosDAO = new AvaliacoesDAO();

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult AdicionarAvaliacao(Avaliacao avaliacao)
        {
            avaliacaosDAO.Adicionar(avaliacao);
            return RedirectToAction("Index", "Avaliacoes");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult AdicionarAvaliacao()
        {
            var aluno = new AlunosDAO();
            var lista = aluno.ListarAlunos();
            ViewBag.ListarAluno = lista;

            var disciplina = new DisciplinasDAO();
            IList<Disciplina> listas = disciplina.ListarDisciplinas();
            ViewBag.ListaDisciplina = listas;

            var avaliacao = new Avaliacao();
            return View(avaliacao);
        }

        // Remover Avaliacao
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult RemoverAvaliacao(int Id)
        {
            Avaliacao avaliacao = avaliacaosDAO.BuscaPorId(Id);
            return View(avaliacao);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        public ActionResult RemoverAvaliacao(Avaliacao avaliacao)
        {
            avaliacaosDAO.Remover(avaliacao);
            return RedirectToAction("VisualizarDetalhes", "Avaliacoes");
        }

        // Editar Avaliacao
        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpGet]
        public ActionResult EditarAvaliacao(int id)
        {
            var avaliacaosDAO = new AvaliacoesDAO();
            Avaliacao avaliacao = avaliacaosDAO.BuscaPorId(id);
            return View(avaliacao);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor })]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarAvaliacao([Bind(Include = "Id, AlunoId, Nota, DisciplinaId, Data")]Avaliacao avaliacao)
        {
            avaliacaosDAO = new AvaliacoesDAO();
            avaliacaosDAO.Editar(avaliacao);
            return RedirectToAction("VisualizarDetalhes", "Avaliacoes");
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Aluno })]
        public ActionResult ListarAvaliacao()
        {
            IList<Avaliacao> avaliacaos = avaliacaosDAO.ListarAvaliacoes();
            return View(avaliacaos);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Aluno })]
        public ActionResult VisualizarDetalhes(int id)
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var avaliacaosDAO = new AvaliacoesDAO();
            var avaliacaos = avaliacaosDAO.ListarAvaliacoes();

            foreach (var avaliacaoo in avaliacaos)
            {
                avaliacaoo.Aluno = alunos.BuscaPorId(avaliacaoo.AlunoId);
            }

            foreach (var avaliacaoo in avaliacaos)
            {
                avaliacaoo.Disciplina = disciplinas.BuscaPorId(avaliacaoo.DisciplinaId);
            }

            Avaliacao avaliacao = avaliacaosDAO.BuscaPorId(id);
            return View(avaliacao);
        }

        [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Professor, TipoPerfil.Aluno, TipoPerfil.Administrador })]
        public ActionResult Index()
        {
            var alunos = new AlunosDAO();
            var disciplinas = new DisciplinasDAO();
            var avaliacaosDAO = new AvaliacoesDAO();
            var avaliacaos = avaliacaosDAO.ListarAvaliacoes();

            foreach (var avaliacao in avaliacaos)
            {
                avaliacao.Aluno = alunos.BuscaPorId(avaliacao.AlunoId);
            }

            foreach (var avaliacao in avaliacaos)
            {
                avaliacao.Disciplina = disciplinas.BuscaPorId(avaliacao.DisciplinaId);
            }

            return View(avaliacaos);
        }
    }
}