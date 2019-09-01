using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Usuario : EntityBase
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public TipoPerfil TipoPerfil { get; set; }
        public int OwnerId { get; set; }
        [NotMapped]
        public Pessoa Objeto { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nomeUsuario, string senha, TipoPerfil tipoPerfil, int ownerId, Pessoa objeto)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
            TipoPerfil = tipoPerfil;
            OwnerId = ownerId;
            Objeto = objeto;
        }
    }
}