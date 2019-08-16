using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Aluno : Pessoa
    {
        [Required]
        public int RegistroDoAluno { get; set; }

        public Responsavel Responsaveis { get; set; }

        public Frequencia Frequencia { get; set; }

        public Disciplina Curso { get; set; }

        public Aluno()
        {

        }

        public Aluno(string nome, int numero, int CEP, string cpf,
            int registroDoAluno, Responsavel responsaveis, Frequencia frequencia, Disciplina curso)
            :base( nome,  numero,  CEP,  cpf)
        {
            RegistroDoAluno = registroDoAluno;
            Responsaveis = responsaveis;
            Frequencia = frequencia;
            Curso = curso;
        }

        public Aluno(int registroDoAluno, Responsavel responsaveis, Frequencia frequencia, Disciplina curso)
        {
            RegistroDoAluno = registroDoAluno;
            Responsaveis = responsaveis;
            Frequencia = frequencia;
            Curso = curso;
        }
    }
}  