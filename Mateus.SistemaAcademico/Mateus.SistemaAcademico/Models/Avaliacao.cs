using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;

namespace Mateus.SistemaAcademico.Models
{
    public class Avaliacao : EntityBase
    {
        public Nota Nota { get; set; }
        public TipoDeAvaliacao TipoDeAvalicao { get; set; }
        public float ValorDaAvalicao { get; set; }

        public Avaliacao()
        {

        }

        public Avaliacao(Nota nota, TipoDeAvaliacao tipoDeAvaliacao, float valorDaAvalicao)
        {
            Nota = nota;
            TipoDeAvalicao = tipoDeAvaliacao;
            ValorDaAvalicao = valorDaAvalicao;
        }
    }
}