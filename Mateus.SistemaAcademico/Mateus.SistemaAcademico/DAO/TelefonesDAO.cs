using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class TelefonesDAO 
    {
        //public SistemaContext contexto = new SistemaContext();

        //public void Adicionar(Telefone telefone)
        //{
        //    contexto.Telefones.Add(telefone);
        //    contexto.SaveChanges();
        //}

        //public void Editar(int telefoneId)
        //{
        //    contexto.Entry(telefoneId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    contexto.SaveChanges();
        //}

        //public void Editar(Telefone telefone)
        //{
        //    contexto.Entry(telefone).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    contexto.Telefones.Update(telefone);
        //    contexto.SaveChanges();
        //}

        //public IList<Telefone> ListarTelefones()
        //{
        //    return contexto.Telefones.Include(c => c.TipoTelefone).ToList();
        //}

        //public void Remover(Telefone telefone)
        //{
        //    int id = 0;
        //    contexto.Telefones.Where(c => c.Id == id).FirstOrDefault();
        //    contexto.Telefones.Remove(telefone);
        //    contexto.SaveChanges();
        //}

        //public Telefone BuscaPorId(int id)
        //{
        //    return contexto.Telefones.Where(c => c.Id == id).FirstOrDefault();
        //}
    }
}



        