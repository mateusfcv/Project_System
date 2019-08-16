using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class DisciplinasDAO : IDisciplina
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Disciplina disciplina)
        {
            contexto.Disciplinas.Add(disciplina);
            contexto.SaveChanges();
        }

        public void Editar(Disciplina disciplinas)
        {
            contexto.Disciplinas.Update(disciplinas);
            contexto.SaveChanges();
        }

        public IList<Disciplina> ListarDisciplinas()
        {
            return contexto.Disciplinas.ToList();
        }

        public void Remover(Disciplina disciplina)
        {
            int id = 0;
            contexto.Disciplinas.Where(x => x.Id == id).FirstOrDefault();
            contexto.Disciplinas.Remove(disciplina);
            contexto.SaveChanges();
        }

        public Disciplina BuscaPorId(int Id)
        {
            return contexto.Disciplinas.Where(u => u.Id == Id).FirstOrDefault();
        }
    }
}