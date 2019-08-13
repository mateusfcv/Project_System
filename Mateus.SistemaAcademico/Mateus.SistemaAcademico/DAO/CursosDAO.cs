using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class CursosDAO : ICurso
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Curso curso)
        {
            contexto.Cursos.Add(curso);
            contexto.SaveChanges();
        }

        public void Editar(Curso curso)
        {
            contexto.Cursos.Update(curso);
            contexto.SaveChanges();
        }

        public IList<Curso> ListarCursos()
        {
            return contexto.Cursos.ToList();
        }

        public void Remover(Curso curso)
        {
            contexto.Cursos.Remove(curso);
            contexto.SaveChanges();
        }

        public Curso BuscaPorId(int id)
        {
            return contexto.Cursos.Where(u => u.Id == id).FirstOrDefault();
        }
    }
}