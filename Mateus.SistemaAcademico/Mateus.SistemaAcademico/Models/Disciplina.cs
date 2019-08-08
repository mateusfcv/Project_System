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
        [Required]
        public string Nome { get; set; }
        [Required]
        public float CargaHoraria { get; set; }

        public virtual List<Conteudo> Conteudo { get; set; }
        public int ConteudoId { get; set; }

        public virtual Frequencia Frequencia { get; set; }
        public int FrequenciaId { get; set; }

        public Professor Professor { get; set; }

        public List<CursoDisciplina> Curso { get; set; }

        public Disciplina ()
        {

        }

        public Disciplina(string nome, float cargaHoraria, List<Conteudo> conteudo, int conteudoId, Frequencia frequencia, int frequenciaId, Professor professor, List<CursoDisciplina> curso)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Conteudo = conteudo;
            ConteudoId = conteudoId;
            Frequencia = frequencia;
            FrequenciaId = frequenciaId;
            Professor = professor;
            Curso = curso;
        }
    }
}