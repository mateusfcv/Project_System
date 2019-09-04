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
        [Required]
        public string NomeUsuario { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
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