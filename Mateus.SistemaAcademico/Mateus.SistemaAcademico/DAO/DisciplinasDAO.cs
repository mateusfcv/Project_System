using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class DisciplinasDAO : IDisposable, IDisciplina
    {
        private SistemaContext contexto;

        public void Adicionar(Disciplina d)
        {
            contexto.Disciplinas.Add(d);
            contexto.SaveChanges();
        }

        public void Atualizar(Disciplina d)
        {
            contexto.Disciplinas.Update(d);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Disciplina> ListarDisciplinas()
        {
            return contexto.Disciplinas.ToList();
        }

        public void Remover(Disciplina d)
        {
            contexto.Disciplinas.Remove(d);
            contexto.SaveChanges();
        }
    }
}