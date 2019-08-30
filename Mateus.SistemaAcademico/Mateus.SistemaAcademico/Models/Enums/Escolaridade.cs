using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models.Enums
{
    public enum Escolaridade
    {
        [Display(Name = "Sem escolaridade")]
        SemEscolaridade,
        [Display(Name = "Fundamental incompleto")]
        FundamentalIncompleto,
        [Display(Name = "Fundamental completo")]
        FundamentalCompleto,
        [Display(Name = "Médio incompleto")]
        MedioIncompleto,
        [Display(Name = "Médico completo")]
        MedioCompleto,
        [Display(Name = "Superior incompleto")]
        SuperiorIncompleto,
        [Display(Name = "Superior completo")]
        SuperiorCompleto,
        [Display(Name = "Mestrado")]
        Mestrado,
        [Display(Name = "Doutorado")]
        Doutorado
    }
}