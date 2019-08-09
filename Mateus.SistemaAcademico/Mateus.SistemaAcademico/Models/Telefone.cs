using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Telefone : EntityBase
    {
        [Required]
        public int Numero { get; set; }

        public Telefone ()
        {

        }

        public Telefone(int numero)
        {
            Numero = numero;
        }
    }
}