using Mateus.SistemaAcademico.Models.JOINS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Disciplina : EntityBase
    {
        public IList<CursoDisciplina> Curso { get; set; }

        public virtual List<Conteudo> Conteudo { get; set; }
        public int ConteudoId { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public float CargaHoraria { get; set; }
        [Required]
        public  Frequencia Frequencia { get; set; }
        [Required]
        public Professor Professor { get; set; }


        public Disciplina ()
        {

        }

        public Disciplina(IList<CursoDisciplina> curso, List<Conteudo> conteudo, int conteudoId, string nome, float cargaHoraria, 
            Frequencia frequencia, Professor professor)
        {
            Curso = curso;
            Conteudo = conteudo;
            ConteudoId = conteudoId;
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Frequencia = frequencia;
            Professor = professor;
        }
    }
}