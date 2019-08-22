using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;

namespace Mateus.SistemaAcademico.Models
{
    public class Notas : EntityBase
    {
        [Required]
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

        [Required]
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        [Required]
        public int TurmaId { get; set; }
        public virtual Turma Turma { get; set; }

        [Required]
        public int TrabalhoId { get; set; }
        public virtual Trabalho Trabalho { get; set; }

        
        public int TipoDeAvaliacoesId { get; set; }
        public TipoDeAvaliacoes TipoDeAvaliacoes  { get; set; }


        public Notas()
        {

        }

        public Notas(int alunoId, Aluno aluno, int disciplinaId, Disciplina disciplina, int turmaId, Turma turma, int trabalhoId, 
            Trabalho trabalho, int tipoDeAvaliacoesId, TipoDeAvaliacoes tipoDeAvaliacoes)
        {
            AlunoId = alunoId;
            Aluno = aluno;
            DisciplinaId = disciplinaId;
            Disciplina = disciplina;
            TurmaId = turmaId;
            Turma = turma;
            TrabalhoId = trabalhoId;
            Trabalho = trabalho;
            TipoDeAvaliacoesId = tipoDeAvaliacoesId;
            TipoDeAvaliacoes = tipoDeAvaliacoes;
        }
    }
}