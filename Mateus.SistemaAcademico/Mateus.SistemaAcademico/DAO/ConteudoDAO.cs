using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class ConteudoDAO : IConteudo
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Conteudo conteudo)
        {
            contexto.Conteudos.Add(conteudo);
            contexto.SaveChanges();
        }

        public void Atualizar(Conteudo conteudo)
        {
            contexto.Conteudos.Update(conteudo);
            contexto.SaveChanges();
        }

        public IList<Conteudo> ListarConteudos()
        {
            return contexto.Conteudos.ToList();
        }

        public void Remover(Conteudo conteudo)
        {
            contexto.Conteudos.Remove(conteudo);
            contexto.SaveChanges();
        }
    }
}