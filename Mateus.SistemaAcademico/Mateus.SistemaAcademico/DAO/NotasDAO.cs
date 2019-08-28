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

        public void Adicionar(Nota nota)
        {
            contexto.Notas.Add(nota);
            contexto.SaveChanges();
        }

        public void Editar(int notaId)
        {
            contexto.Entry(notaId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Nota nota)
        {
            contexto.Entry(nota).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Notas.Update(nota);
            contexto.SaveChanges();
        }

        public List<Nota> ListarNotas()
        {
            return contexto.Notas.ToList();
        }

        public void Remover(Nota nota)
        {
            int id = 0;
            contexto.Notas.Where(c => c.Id == id).FirstOrDefault();
            contexto.Notas.Remove(nota);
            contexto.SaveChanges();
        }

        public Nota BuscaPorId(int id)
        {
            return contexto.Notas.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        