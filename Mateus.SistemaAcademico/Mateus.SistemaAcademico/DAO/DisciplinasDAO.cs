using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class DisciplinasDAO
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Disciplina disciplina)
        {
            contexto.Disciplinas.Add(disciplina);
            contexto.SaveChanges();
        }

        public void Editar(int disciplinaId)
        {
            contexto.Entry(disciplinaId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Disciplina disciplina)
        {
            contexto.Entry(disciplina).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Disciplinas.Update(disciplina);
            contexto.SaveChanges();
        }

        public List<Disciplina> ListarDisciplinas()
        {
            return contexto.Disciplinas.ToList();
        }

        public void Remover(Disciplina disciplina)
        {
            int id = 0;
            contexto.Disciplinas.Where(c => c.Id == id).FirstOrDefault();
            contexto.Disciplinas.Remove(disciplina);
            contexto.SaveChanges();
        }

        public Disciplina BuscaPorId(int id)
        {
            return contexto.Disciplinas.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        