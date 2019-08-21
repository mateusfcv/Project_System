using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Usuario : EntityBase
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
        // Qual o tipo de usuario (Professor, Aluno ou Secretaria)
        [Required]
        public int Tipo { get; set; }
    }
}