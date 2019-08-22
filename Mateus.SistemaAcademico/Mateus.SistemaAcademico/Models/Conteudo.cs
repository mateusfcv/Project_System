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
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public TipoConteudo TipoConteudos { get; set; }
        [Required]
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }

        public Conteudo()
        {
             
        }

        public Conteudo(string nome, string descricao, TipoConteudo tipoConteudos, int disciplinaId, Disciplina disciplina)
        {
            Nome = nome;
            Descricao = descricao;
            TipoConteudos = tipoConteudos;
            DisciplinaId = disciplinaId;
            Disciplina = disciplina;
        }
    }
}
