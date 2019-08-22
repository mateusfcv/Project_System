using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class TipoDeAvaliacoes : EntityBase
    {
        [Required]
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        [Required]
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataAvaliacao { get; set; }
        public float NotaAvaliacoes { get; set; }

        public float NotaSubstitutivas { get; set; }

        public float NotaExameFinal { get; set; }

        public TipoDeAvaliacoes()
        {

        }

        public TipoDeAvaliacoes(int alunoId, Aluno aluno, int disciplinaId, Disciplina disciplina, DateTime dataAvaliacao,
            float notaAvaliacoes, float notaSubstitutivas, float notaExameFinal)
        {
            AlunoId = alunoId;
            Aluno = aluno;
            DisciplinaId = disciplinaId;
            Disciplina = disciplina;
            DataAvaliacao = dataAvaliacao;
            NotaAvaliacoes = notaAvaliacoes;
            NotaSubstitutivas = notaSubstitutivas;
            NotaExameFinal = notaExameFinal;
        }
    }
}