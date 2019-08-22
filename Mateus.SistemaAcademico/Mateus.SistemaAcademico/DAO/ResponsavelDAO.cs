using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class ResponsavelDAO
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Responsavel responsavel)
        {
            contexto.Responsavel.Add(responsavel);
            contexto.SaveChanges();
        }

        public void Editar(int responsavelId)
        {
            contexto.Entry(responsavelId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Responsavel responsavel)
        {
            contexto.Entry(responsavel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Responsavel.Update(responsavel);
            contexto.SaveChanges();
        }

        public IList<Responsavel> ListarResponsavel()
        {
            return contexto.Responsavel.ToList();
        }

        public void Remover(Responsavel responsavel)
        {
            int id = 0;
            contexto.Responsavel.Where(c => c.Id == id).FirstOrDefault();
            contexto.Responsavel.Remove(responsavel);
            contexto.SaveChanges();
        }

        public Responsavel BuscaPorId(int id)
        {
            return contexto.Responsavel.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        