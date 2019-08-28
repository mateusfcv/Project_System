using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class ProfessoresDAO
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Professor professor)
        {
            contexto.Professor.Add(professor);
            contexto.SaveChanges();
        }

        public void Editar(int professorId)
        {
            contexto.Entry(professorId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Professor professor)
        {
            contexto.Entry(professor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
            return contexto.Professor.Include(x => x.Disciplinas).Where(p => p.Id == id).FirstOrDefault();
        }

        public Professor BuscaProfessor(string login, string senha)
        {
            return contexto.Professor.FirstOrDefault(x => x.NomeUsuario == login && x.Senha == senha);
        }
    }
}



        