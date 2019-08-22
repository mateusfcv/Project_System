using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class FrequenciasDAO
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Frequencia frequencia)
        {
            contexto.Frequencias.Add(frequencia);
            contexto.SaveChanges();
        }

        public void Editar(int frequenciaId)
        {
            contexto.Entry(frequenciaId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Frequencia frequencia)
        {
            contexto.Entry(frequencia).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Frequencias.Update(frequencia);
            contexto.SaveChanges();
        }

        public IList<Frequencia> ListarFrequencias()
        {
            return contexto.Frequencias.ToList();
        }

        public void Remover(Frequencia frequencia)
        {
            int id = 0;
            contexto.Frequencias.Where(c => c.Id == id).FirstOrDefault();
            contexto.Frequencias.Remove(frequencia);
            contexto.SaveChanges();
        }

        public Frequencia BuscaPorId(int id)
        {
            return contexto.Frequencias.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        