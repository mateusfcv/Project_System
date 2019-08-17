using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Editar(int cursoId)
        {
            contexto.Entry(cursoId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Curso curso)
        {
            contexto.Entry(curso).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Cursos.Update(curso);
            contexto.SaveChanges();
        }

        public IList<Curso> ListarCursos()
        {
            return contexto.Cursos.Include(p => p.TipoCurso).ToList();
        }

        public void Remover(Curso curso)
        {
            int id = 0;
            contexto.Cursos.Where(x => x.Id == id).FirstOrDefault();
            contexto.Cursos.Remove(curso);
            contexto.SaveChanges();
        }

        public Curso BuscaPorId(int Id)
        {
            return contexto.Cursos.Where(u => u.Id == Id).FirstOrDefault();
        }
    }
}



        