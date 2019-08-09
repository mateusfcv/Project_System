using Mateus.SistemaAcademico.Bussines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models;

namespace Mateus.SistemaAcademico
{
    public class ValidacaoNome
    {
        public string Dados { get; set; }



        public bool ValidaNome(string Dados)

        {

            if (Dados == null)
                 
                throw new CampoNullException();
           
            return true;
        }
    }
}