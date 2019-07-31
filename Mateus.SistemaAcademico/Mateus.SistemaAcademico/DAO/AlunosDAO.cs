using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class AlunosDAO : IDisposable, IAluno
    {
        private SistemaContext contexto;

        public void Adicionar(Aluno a)
        {
            contexto.Alunos.Add(a);
            contexto.SaveChanges();
        }

        public IList<Aluno> ListarAlunos() 
        {
            return contexto.Alunos.ToList();
        }

        public void Atualizar(Aluno a)
        {
            contexto.Alunos.Update(a);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public void Remover(Aluno a)
        {
            contexto.Alunos.Remove(a);
            contexto.SaveChanges();
        }
    }
}