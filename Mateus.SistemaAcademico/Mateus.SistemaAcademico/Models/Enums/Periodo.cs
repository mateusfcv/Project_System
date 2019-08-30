using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models.Enums
{
    public enum Periodo
    {
        [Display(Name = "Manhã")]
        Manha,
        [Display(Name = "Tarde")]
        Tarde,
        [Display(Name = "Noite")]
        Noite,
        [Display(Name = "Integral")]
        Integral
    }
}