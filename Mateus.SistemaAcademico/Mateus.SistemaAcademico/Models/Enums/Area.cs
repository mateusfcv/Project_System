using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models.Enums
{
    public enum Area
    {
        [Display(Name = "Exatas")]
        Exatas,
        [Display(Name = "Humanas")]
        Humanas,
        [Display(Name = "Biológicas")]
        Biologicas
    }
}