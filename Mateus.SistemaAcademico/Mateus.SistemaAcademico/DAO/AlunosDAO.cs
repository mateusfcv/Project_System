using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class AlunosDAO : IAluno
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Aluno aluno)
        {
            contexto.Alunos.Add(aluno);
            contexto.SaveChanges();
        }

        public void Editar(Aluno aluno)
        {
            contexto.Alunos.Update(aluno);
            contexto.SaveChanges();
        }

        public IList<Aluno> ListarAlunos()
        {
            return contexto.Alunos.ToList();
        }

        public void Remover(Aluno aluno)
        {
            contexto.Alunos.Remove(aluno);
            contexto.SaveChanges();
        }
    }
}