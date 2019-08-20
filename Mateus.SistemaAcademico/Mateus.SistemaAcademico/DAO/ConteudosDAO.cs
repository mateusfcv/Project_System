using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class ConteudosDAO : IConteudo
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Conteudo conteudo)
        {
            contexto.Conteudos.Add(conteudo);
            contexto.SaveChanges();
        }

        public void Editar(int conteudoId)
        {
            contexto.Entry(conteudoId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Conteudo conteudo)
        {
            contexto.Entry(conteudo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Conteudos.Update(conteudo);
            contexto.SaveChanges();
        }

        public IList<Conteudo> ListarConteudos()
        {
            return contexto.Conteudos.Include(c => c.TipoConteudos).ToList();
        }

        public void Remover(Conteudo conteudo)
        {
            int id = 0;
            contexto.Conteudos.Where(c => c.Id == id).FirstOrDefault();
            contexto.Conteudos.Remove(conteudo);
            contexto.SaveChanges();
        }

        public Conteudo BuscaPorId(int Id)
        {
            return contexto.Conteudos.Where(u => u.Id == Id).FirstOrDefault();
        }
    }
}