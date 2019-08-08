using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class ProfessoresDAO : IProfessor, IDisposable
    {
        public SistemaContext contexto;

        public void Adicionar(Professor p)
        {
            contexto.Professor.Add(p);
            contexto.SaveChanges();
        }

        public void Atualizar(Professor p)
        {
            contexto.Professor.Update(p);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Professor> ListarProfessores()
        {
            return contexto.Professor.ToList();
        }

        public void Remover(Professor p)
        {
            contexto.Professor.Remove(p);
            contexto.SaveChanges();
        }
    }
}