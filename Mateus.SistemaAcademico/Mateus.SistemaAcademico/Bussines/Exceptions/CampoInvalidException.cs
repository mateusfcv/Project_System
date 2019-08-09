using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Bussines
{
    public class CampoInvalidException : Exception
    {
        public CampoInvalidException()
        {

        }

        public CampoInvalidException(string message) : base(message)
        {
            message = ("Erro! O campo é inválido!");
        }

        public CampoInvalidException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}