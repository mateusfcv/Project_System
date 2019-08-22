using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class TrabalhosDAO 
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Trabalho trabalho)
        {
            contexto.Trabalhos.Add(trabalho);
            contexto.SaveChanges();
        }

        public void Editar(int trabalhoId)
        {
            contexto.Entry(trabalhoId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Trabalho trabalho)
        {
            contexto.Entry(trabalho).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Trabalhos.Update(trabalho);
            contexto.SaveChanges();
        }

        public IList<Trabalho> ListarTrabalhos()
        {
            return contexto.Trabalhos.ToList();
        }

        public void Remover(Trabalho trabalho)
        {
            int id = 0;
            contexto.Trabalhos.Where(c => c.Id == id).FirstOrDefault();
            contexto.Trabalhos.Remove(trabalho);
            contexto.SaveChanges();
        }

        public Trabalho BuscaPorId(int id)
        {
            return contexto.Trabalhos.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        