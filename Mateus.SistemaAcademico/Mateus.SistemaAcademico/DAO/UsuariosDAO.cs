using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class UsuariosDAO
    {
        private readonly SistemaContext contexto;

        public UsuariosDAO()
        {
            contexto = new SistemaContext();
        }

        public void Adicionar(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public IList<Usuario> Lista()
        {
            return contexto.Usuarios.ToList();
        }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public void Editar(Usuario usuario)
        {
            contexto.Usuarios.Update(usuario);
            contexto.SaveChanges();
        }

        public Usuario Busca(string login, string senha)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.NomeUsuario == login && u.Senha == senha);
        }

        public void Remover(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }
    }
}