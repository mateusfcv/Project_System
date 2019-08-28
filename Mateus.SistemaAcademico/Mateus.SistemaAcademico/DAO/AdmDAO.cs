using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class AdmDAO 
    {
        public SistemaContext contexto = new SistemaContext();

        public void Adicionar(Administrador adm)
        {
            contexto.Administradores.Add(adm);
            contexto.SaveChanges();
        }

        public void Editar(int admId)
        {
            contexto.Entry(admId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Administrador adm)
        {
            contexto.Entry(adm).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.Administradores.Update(adm);
            contexto.SaveChanges();
        }

        public List<Administrador> ListarAdm()
        {
            return contexto.Administradores.ToList();
        }

        public void Remover(Administrador adm)
        {
            int id = 0;
            contexto.Administradores.Where(c => c.Id == id).FirstOrDefault();
            contexto.Administradores.Remove(adm);
            contexto.SaveChanges();
        }

        public Administrador BuscaPorId(int id)
        {
            return contexto.Administradores.Where(c => c.Id == id).FirstOrDefault();
        }

        public Administrador BuscaAdm(string login, string senha)
        {
            return contexto.Administradores.FirstOrDefault(x => x.NomeUsuario == login && x.Senha == senha);
        }
    }
}



        