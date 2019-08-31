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
        [Display(Name = "Tecnológicas")]
        Tecnologicas,
        [Display(Name = "Agrárias")]
        Agrarias,
        [Display(Name = "Humanas")]
        Humanas,
        [Display(Name = "Sociais ")]
        Sociais,
        [Display(Name = "Biológicas")]
        Biologicas,
        [Display(Name = "Saúde")]
        Saude
        

    }
}