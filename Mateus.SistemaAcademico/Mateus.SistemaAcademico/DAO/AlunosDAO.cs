using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class AlunosDAO : IAlunosDAO, IDisposable
    {
        private SistemaContext contexto;

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