using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class AvaliacoesDAO 
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Avaliacao avaliacao)
        {
            contexto.Avaliacoes.Add(avaliacao);
            contexto.SaveChanges();
        }

        public void Editar(int avaliacaoId)
        {
            contexto.Entry(avaliacaoId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Avaliacao avaliacao)
        {
            contexto.Entry(avaliacao).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Avaliacoes.Update(avaliacao);
            contexto.SaveChanges();
        }

        public List<Avaliacao> ListarAvaliacoes()
        {
            return contexto.Avaliacoes.ToList();
        }

        public void Remover(Avaliacao avaliacao)
        {
            int id = 0;
            contexto.Avaliacoes.Where(c => c.Id == id).FirstOrDefault();
            contexto.Avaliacoes.Remove(avaliacao);
            contexto.SaveChanges();
        }

        public Avaliacao BuscaPorId(int id)
        {
            return contexto.Avaliacoes.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        