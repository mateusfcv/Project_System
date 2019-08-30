using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models.Enums
{
    public enum TipoPerfil
    {
        [Display(Name = "Administrador")]
        Administrador,
        [Display(Name ="Secretária")]
        Secretaria,
        [Display(Name = "Professor")]
        Professor,
        [Display(Name = "Aluno")]
        Aluno
    }
}