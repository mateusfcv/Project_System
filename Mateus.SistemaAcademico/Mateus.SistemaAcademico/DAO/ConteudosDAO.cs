using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class ConteudosDAO : IDisposable, IConteudo
    {
        private SistemaContext contexto;

        public void Adicionar(Conteudo c)
        {
            contexto.Conteudos.Add(c);
            contexto.SaveChanges();
        }

        public void Atualizar(Conteudo c)
        {
            contexto.Conteudos.Update(c);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Conteudo> ListarConteudos()
        {
            return contexto.Conteudos.ToList();
        }

        public void Remover(Conteudo c)
        {
            contexto.Conteudos.Remove(c);
            contexto.SaveChanges();
        }
    }
}