using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class ExamesFinaisDAO 
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(ExameFinal exameFinal)
        {
            contexto.ExamesFinais.Add(exameFinal);
            contexto.SaveChanges();
        }

        public void Editar(int exameFinalId)
        {
            contexto.Entry(exameFinalId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(ExameFinal exameFinal)
        {
            contexto.Entry(exameFinal).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.ExamesFinais.Update(exameFinal);
            contexto.SaveChanges();
        }

        public List<ExameFinal> ListarExamesFinais()
        {
            return contexto.ExamesFinais.ToList();
        }

        public void Remover(ExameFinal exameFinal)
        {
            int id = 0;
            contexto.ExamesFinais.Where(c => c.Id == id).FirstOrDefault();
            contexto.ExamesFinais.Remove(exameFinal);
            contexto.SaveChanges();
        }

        public ExameFinal BuscaPorId(int id)
        {
            return contexto.ExamesFinais.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}



        