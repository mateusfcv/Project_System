using System;
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
    //[AutorizacaoFilter]
    //public class EnderecosController : Controller
    //{
    //    // get: enderecos
    //    EnderecosDAO enderecosDAO = new EnderecosDAO();

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    [HttpPost]
    //    public ActionResult AdicionarEndereco(Endereco endereco)
    //    {
    //        enderecosDAO.Adicionar(endereco);
    //        return RedirectToAction("Index", "Enderecos");
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    [HttpGet]
    //    public ActionResult AdicionarEndereco()
    //    {
    //            var endereco = new Endereco();
    //            return View(endereco);
    //    }

    //    // Remover Endereco
    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    [HttpGet]
    //    public ActionResult RemoverEndereco(int Id)
    //    {
    //        Endereco endereco = enderecosDAO.BuscaPorId(Id);
    //        return View(endereco);
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    [HttpPost]
    //    public ActionResult RemoverEndereco(Endereco endereco)
    //    {
    //        enderecosDAO.Remover(endereco);
    //        return RedirectToAction("Index", "Enderecos");
    //    }

    //    // Editar Endereco
    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    [HttpGet]
    //    public ActionResult EditarEndereco(int Id)
    //    {
    //        var enderecosDAO = new EnderecosDAO();
    //        Endereco endereco = enderecosDAO.BuscaPorId(Id);
    //        return View(endereco);
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult EditarEndereco([Bind(Include = "Id, Cep, NomeRua, Numero, Complemento, Bairro, Estados, Cidades")]Endereco endereco)
    //    {
    //        enderecosDAO = new EnderecosDAO();
    //        enderecosDAO.Editar(endereco);
    //        return RedirectToAction("Index", "Enderecos");
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    public ActionResult ListarEndereco()
    //    {
    //        IList<Endereco> enderecos = enderecosDAO.ListarEnderecos();
    //        return View(enderecos);
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    public ActionResult VisualizarDetalhes(int id)
    //    {
    //        Endereco endereco = enderecosDAO.BuscaPorId(id);
    //        return View(endereco);
    //    }

    //    [AutorizacaoFilter(Roles = new TipoPerfil[] { TipoPerfil.Administrador, TipoPerfil.Secretaria })]
    //    public ActionResult Index()
    //    {
    //        var enderecosDAO = new EnderecosDAO();
    //        var enderecos = enderecosDAO.ListarEnderecos();
    //        ViewBag.Enderecos = enderecos;
    //        return View();
    //    }
    //}
}