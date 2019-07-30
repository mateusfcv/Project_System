using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Avaliacao : EntityBase
    {
        public TipoAvaliacao TipoAvaliacao {get; set;}
        public Nota Nota { get; set; }
        public int Valor { get; set; }

        public Avaliacao()
        {

        }

        public Avaliacao(TipoAvaliacao tipoAvaliacao, Nota nota, int valor)
        {
            TipoAvaliacao = tipoAvaliacao;
            Nota = nota;
            Valor = valor;
        }
    }
}