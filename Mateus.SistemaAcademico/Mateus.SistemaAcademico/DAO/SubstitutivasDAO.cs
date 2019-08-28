using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class SubstitutivasDAO 
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Substitutivas substitutivas)
        {
            contexto.Substitutivas.Add(substitutivas);
            contexto.SaveChanges();
        }

        public void Editar(int substitutivasId)
        {
            contexto.Entry(substitutivasId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Substitutivas substitutivas)
        {
            contexto.Entry(substitutivas).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Substitutivas.Update(substitutivas);
            contexto.SaveChanges();
        }

        public List<Substitutivas> ListarSubstitutivas()
        {
            return contexto.Substitutivas.ToList();
        }

        public void Remover(Substitutivas substitutivas)
        {
            int id = 0;
            contexto.Substitutivas.Where(c => c.Id == id).FirstOrDefault();
            contexto.Substitutivas.Remove(substitutivas);
            contexto.SaveChanges();
        }

        public Substitutivas BuscaPorId(int id)
        {
            return contexto.Substitutivas.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        