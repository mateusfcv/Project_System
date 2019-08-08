using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class CursosDAO : IDisposable, ICurso
    {
        private SistemaContext contexto; 

        public void Adicionar(Curso c)
        {
            contexto.Cursos.Add(c);
            contexto.SaveChanges();
        }

        public void Atualizar(Curso c)
        {
            contexto.Cursos.Update(c);
            contexto.SaveChanges();
        }

        public IList<Curso> ListarCursos()
        {
            return contexto.Cursos.ToList();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public void Remover(Curso c)
        {
            contexto.Cursos.Remove(c);
            contexto.SaveChanges();
        }
    }
}