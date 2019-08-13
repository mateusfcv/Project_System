using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public void Atualizar(Professor professor)
        {
            contexto.Professor.Update(professor);
            contexto.SaveChanges();
        }

        public IList<Professor> ListarProfessores()
        {
            return contexto.Professor.ToList();
        }

        public void Remover(Professor professor)
        {
            contexto.Professor.Remove(professor);
            contexto.SaveChanges();
        }
    }
}