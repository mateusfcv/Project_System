using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class NotasDAO 
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Notas notas)
        {
            contexto.Notas.Add(notas);
            contexto.SaveChanges();
        }

        public void Editar(int notasId)
        {
            contexto.Entry(notasId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Notas notas)
        {
            contexto.Entry(notas).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Notas.Update(notas);
            contexto.SaveChanges();
        }

        public IList<Notas> ListarNotas()
        {
            return contexto.Notas.ToList();
        }

        public void Remover(Notas notas)
        {
            int id = 0;
            contexto.Notas.Where(c => c.Id == id).FirstOrDefault();
            contexto.Notas.Remove(notas);
            contexto.SaveChanges();
        }

        public Notas BuscaPorId(int id)
        {
            return contexto.Notas.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        