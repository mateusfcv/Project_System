using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Telefone : EntityBase
    {
        public int Valor { get; set; }

        public Telefone ()
        {

        }

        public Telefone(int valor)
        {
            Valor = valor;
        }
    }
}