using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class PessoaDAOEntity : IPessoaDAO, IDisposable
    {
        private SistemaContext contexto;

        public void Adicionar(Pessoa p)
        {
            contexto.Pessoas.Add(p);
            contexto.SaveChanges();
        }

        public void Atualizar(Pessoa p)
        {
            contexto.Pessoas.Update(p);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Pessoa> Pessoas()
        {
            return contexto.Pessoas.ToList();
        }

        public void Remover(Pessoa p)
        {
            contexto.Pessoas.Remove(p);
            contexto.SaveChanges();
        }
    }
}