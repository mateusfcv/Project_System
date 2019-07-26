using Mateus.SistemaAcademico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Notas
    {
        public float Trabalhos;

        public ITipoProva Provas;

        public float Media;
    }
}