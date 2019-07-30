using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;


namespace Mateus.SistemaAcademico.Models
{
    public class TipoAvaliacao : EntityBase
    {
        public string Descricao { get; set; }
        public TipoDeProva TipoDeProva { get; set; }
        public float Valor { get; set; }

        public TipoAvaliacao()
        {

        }

        public TipoAvaliacao(string descricao, TipoDeProva tipoDeProva, float valor)
        {
            Descricao = descricao;
            TipoDeProva = tipoDeProva;
            Valor = valor;
        }
    }
}