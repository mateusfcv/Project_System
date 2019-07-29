using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Telefone
    {
        public int IdTelefone { get; set; }
        public int Valor { get; set; }

        public Telefone ()
        {

        }

        public Telefone(int idTelefone, int valor)
        {
            IdTelefone = idTelefone;
            Valor = valor;
        }
    }
}