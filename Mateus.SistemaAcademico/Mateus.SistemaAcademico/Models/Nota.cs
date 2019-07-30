using Mateus.SistemaAcademico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Nota : EntityBase
    {
        public Avaliacao Avaliacao { get; set; }
        public Trabalho Trabalho { get; set; }

        public Nota()
        {

        }

        public Nota(Avaliacao avaliacao, Trabalho trabalho)
        {
            Avaliacao = avaliacao;
            Trabalho = trabalho;
        }
    }
}