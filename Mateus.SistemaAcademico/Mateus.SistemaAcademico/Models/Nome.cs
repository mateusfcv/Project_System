using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Nome : EntityBase
    {
        public string Dados { get; set; }

        public Nome(string Dados)
        {
            if (Dados == null)
                throw new CampoInvalidException();

            else if (Regex.IsMatch(Dados, (@"[^a-zA-Z0-9]")))
            {
                throw new CampoInvalidException("Caracteres especiais não devem ser aceitos!");
            }

            else
            {
                this.Dados = Dados;
            }

        }
    }
}