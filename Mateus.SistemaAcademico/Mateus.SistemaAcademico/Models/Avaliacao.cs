using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;

namespace Mateus.SistemaAcademico.Models
{
    public class Avaliacao : EntityBase
    {
        [Required]
        public TipoDeAvaliacao TipoDeAvalicao { get; set; }
        [Required]
        public float ValorDaAvalicao { get; set; }

        public Avaliacao()
        {

        }

        public Avaliacao(TipoDeAvaliacao tipoDeAvaliacao, float valorDaAvalicao)
        {
            TipoDeAvalicao = tipoDeAvaliacao;
            ValorDaAvalicao = valorDaAvalicao;
        }
    }
}