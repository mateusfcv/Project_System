using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Usuario : EntityBase
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public TipoPerfil TipoPerfil { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nomeUsuario, string senha, TipoPerfil tipoPerfil)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
            TipoPerfil = tipoPerfil;
        }
    }
}