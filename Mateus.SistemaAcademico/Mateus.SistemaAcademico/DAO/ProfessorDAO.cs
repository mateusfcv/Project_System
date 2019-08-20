using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace Mateus.SistemaAcademico.DAO
{
    public class ProfessorDAO : IProfessor
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Professor professor)
        {
            contexto.Professor.Add(professor);
            contexto.SaveChanges();
        }

        public void Editar(int professorId)
        {
            contexto.Entry(professorId).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Professor professor)
        {
            contexto.Entry(professor).State = EntityState.Modified;
            contexto.Professor.Update(professor);
            contexto.SaveChanges();
        }

        public IList<Professor> ListarProfessores()
        {
            return contexto.Professor.ToList();
        }

        public void Remover(Professor professor)
        {
            int id = 0;
            contexto.Professor.Where(p => p.Id == id).FirstOrDefault();
            contexto.Professor.Remove(professor);
            contexto.SaveChanges();
        }

        public Professor BuscaPorId(int id)
        {
            return contexto.Professor.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}