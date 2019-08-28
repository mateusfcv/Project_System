using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class SecretariasDAO
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Secretaria secretaria)
        {
            contexto.Secretarias.Add(secretaria);
            contexto.SaveChanges();
        }

        public void Editar(int secretariaId)
        {
            contexto.Entry(secretariaId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Secretaria secretaria)
        {
            contexto.Entry(secretaria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Secretarias.Update(secretaria);
            contexto.SaveChanges();
        }

        public IList<Secretaria> ListarSecretarias()
        {
            return contexto.Secretarias.ToList();
        }

        public void Remover(Secretaria secretaria)
        {
            int id = 0;
            contexto.Secretarias.Where(c => c.Id == id).FirstOrDefault();
            contexto.Secretarias.Remove(secretaria);
            contexto.SaveChanges();
        }

        public Secretaria BuscaPorId(int id)
        {
            return contexto.Secretarias.Where(c => c.Id == id).FirstOrDefault();
        }

        public Secretaria BuscaSecretaria(string login, string senha)
        {
            return contexto.Secretarias.FirstOrDefault(x => x.NomeUsuario == login && x.Senha == senha);
        }
    }
}



        