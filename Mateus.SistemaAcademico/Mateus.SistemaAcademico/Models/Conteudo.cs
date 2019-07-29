using Mateus.SistemaAcademico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Conteudo
    {
        public int IdConteudo { get; set; }
        public string Descricao { get; set; }

        public Conteudo()
        {

        }

        public Conteudo(int Idconteudo, string descricao)
        {
            IdConteudo = Idconteudo;
            Descricao = descricao;
        }
    }
}
