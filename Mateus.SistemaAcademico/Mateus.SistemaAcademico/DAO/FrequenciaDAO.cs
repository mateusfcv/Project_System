using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class FrequenciaDAO : IDisposable, IFrequencia
    {
        private SistemaContext contexto;

        public void Adicionar(Frequencia f)
        {
            contexto.Frequencias.Add(f);
            contexto.SaveChanges();
        }

        public void Atualizar(Frequencia f)
        {
            contexto.Frequencias.Update(f);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Frequencia> ListarFrequencias()
        {
            return contexto.Frequencias.ToList();
        }

        public void Remover(Frequencia f)
        {
            contexto.Frequencias.Remove(f);
            contexto.SaveChanges();
        }
    }
}