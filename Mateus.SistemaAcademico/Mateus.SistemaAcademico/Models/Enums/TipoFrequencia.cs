using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models.Enums
{
    public enum TipoFrequencia : int
    {
        [Display(Name = "Presença")]
        Presenca = 0,
        Falta = 1
    }
}