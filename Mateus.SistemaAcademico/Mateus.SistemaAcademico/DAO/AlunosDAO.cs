using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class AlunosDAO
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Aluno aluno)
        {
            contexto.Alunos.Add(aluno);
            contexto.SaveChanges();
        }

        public void Editar(int alunoId)
        {
            contexto.Entry(alunoId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Aluno aluno)
        {
            contexto.Entry(aluno).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Alunos.Update(aluno);
            contexto.SaveChanges();
        }

        public IList<Aluno> ListarAlunos()
        {
            return contexto.Alunos.ToList();
        }

        public void Remover(Aluno aluno)
        {
            int id = 0;
            contexto.Alunos.Where(c => c.Id == id).FirstOrDefault();
            contexto.Alunos.Remove(aluno);
            contexto.SaveChanges();
        }

        public Aluno BuscaPorId(int id)
        {
            return contexto.Alunos.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        