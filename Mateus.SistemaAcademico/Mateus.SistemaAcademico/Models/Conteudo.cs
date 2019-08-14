using Mateus.SistemaAcademico.Interfaces;
using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Conteudo : EntityBase
    {
        [Required]
        public string Descricao { get; set; }
        [Required]
        public TipoConteudo TipoConteudos { get; set; }

        public Conteudo()
        {
             
        }

        public Conteudo(string descricao, TipoConteudo tipoConteudos)
        {
            Descricao = descricao;
            TipoConteudos = tipoConteudos;
        }
    }
}
