using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class ResponsavelDAO : IResponsavel
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Responsavel responsavel)
        {
            contexto.Responsaveis.Add(responsavel);
            contexto.SaveChanges();
        }

        public void Editar(Responsavel responsavel)
        {
            contexto.Responsaveis.Update(responsavel);
            contexto.SaveChanges();
        }

        public IList<Responsavel> ListarResponsavel()
        {
            return contexto.Responsaveis.ToList();
        }

        public void Remover(Responsavel responsavel)
        {
            contexto.Responsaveis.Remove(responsavel);
            contexto.SaveChanges();
        }
    }
}