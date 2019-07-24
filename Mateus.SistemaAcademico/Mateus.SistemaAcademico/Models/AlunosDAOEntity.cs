using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class AlunosDAOEntity : IAlunosDAO, IDisposable
    {
        private SistemaContext contexto;

        public AlunosDAOEntity()
        {
            this.contexto = new SistemaContext();
        }

        public void Adicionar(Alunos a)
        {
            contexto.Alunos.Add(a);
            contexto.SaveChanges();
        }

        public IList<Alunos> Alunos()
        {
            return contexto.Alunos.ToList();
        }

        public void Atualizar(Alunos a)
        {
            contexto.Alunos.Update(a);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public void Remover(Alunos a)
        {
            contexto.Alunos.Remove(a);
            contexto.SaveChanges();
        }
    }
}