using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Telefones
    {
        public int TelfoneId { get; set; }
        public int Valor;

        public Pessoa Pessoa;
    }
}