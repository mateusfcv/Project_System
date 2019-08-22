using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class TurmasDAO 
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Turma turma)
        {
            contexto.Turmas.Add(turma);
            contexto.SaveChanges();
        }

        public void Editar(int turmaId)
        {
            contexto.Entry(turmaId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Turma turma)
        {
            contexto.Entry(turma).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Turmas.Update(turma);
            contexto.SaveChanges();
        }

        public IList<Turma> ListarTurmas()
        {
            return contexto.Turmas.ToList();
        }

        public void Remover(Turma turma)
        {
            int id = 0;
            contexto.Turmas.Where(c => c.Id == id).FirstOrDefault();
            contexto.Turmas.Remove(turma);
            contexto.SaveChanges();
        }

        public Turma BuscaPorId(int id)
        {
            return contexto.Turmas.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        