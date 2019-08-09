﻿using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class AlunosDAO : IDisposable, IAluno
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Aluno a)
        {
            contexto.Alunos.Add(a);
            contexto.SaveChanges();
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

        public IList<Aluno> ListarAlunos()
        {
            return contexto.Alunos.ToList();
        }

        public void Remover(Aluno a)
        {
            contexto.Alunos.Remove(a);
            contexto.SaveChanges();
        }
    }
}