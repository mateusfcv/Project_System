using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Bussines
{
    public class CampoNullException : Exception
    {
        public CampoNullException()
        {

        }

        public CampoNullException(string message)
            : base(message)
        {
            message = ("Erro! Nenhum dos campos pode ser nulo!");
        }

        public CampoNullException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}