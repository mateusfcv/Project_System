using Mateus.SistemaAcademico.Bussines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models;
using System.Text.RegularExpressions;

namespace Mateus.SistemaAcademico
{
    public class ValidacaoNome
    {
        public string Dados { get; set; }

        public bool Validar(string Dados)
        {
            if (Dados == null)
                throw new CampoNullException();
            else if (Regex.IsMatch(Dados, (@"[^a-zA-Z]")))
            {
                return false;
            }
            return true;
        }

        public ValidacaoNome()
        {

        }

    }
}