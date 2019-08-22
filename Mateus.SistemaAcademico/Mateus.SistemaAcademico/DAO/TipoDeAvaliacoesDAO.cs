using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class TipoDeAvaliacoesDAO  
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(TipoDeAvaliacoes tipoDeAvaliacoes)
        {
            contexto.TipoDeAvaliacoes.Add(tipoDeAvaliacoes);
            contexto.SaveChanges();
        }

        public void Editar(int tipoDeAvaliacoesId)
        {
            contexto.Entry(tipoDeAvaliacoesId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(TipoDeAvaliacoes tipoDeAvaliacoes)
        {
            contexto.Entry(tipoDeAvaliacoes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.TipoDeAvaliacoes.Update(tipoDeAvaliacoes);
            contexto.SaveChanges();
        }

        public IList<TipoDeAvaliacoes> ListarTipoDeAvaliacoes()
        {
            return contexto.TipoDeAvaliacoes.ToList();
        }

        public void Remover(TipoDeAvaliacoes tipoDeAvaliacoes)
        {
            int id = 0;
            contexto.TipoDeAvaliacoes.Where(c => c.Id == id).FirstOrDefault();
            contexto.TipoDeAvaliacoes.Remove(tipoDeAvaliacoes);
            contexto.SaveChanges();
        }

        public TipoDeAvaliacoes BuscaPorId(int id)
        {
            return contexto.TipoDeAvaliacoes.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        