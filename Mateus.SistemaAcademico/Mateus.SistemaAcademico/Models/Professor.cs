using Mateus.SistemaAcademico.Models.JOINS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Professor : Pessoa
    {
        //public IList<ProfessorCurso> Curso { get; set; }

        [Required]
        public int RegistroDoProfessor { get; set; }
        [Required]
        public Disciplina DisciplinasMinistratadas { get; set; }
        [Required]
        public string Titulacao { get; set; }

        public Professor ()
        {

        }

        public Professor(string nome, int CEP, int numero, string cpf,
           int registroDoProfessor, Disciplina disciplinasMinistratadas,
             string titulacao)
            :base( nome,  CEP,  numero,  cpf)
        {
            RegistroDoProfessor = registroDoProfessor;
            DisciplinasMinistratadas = disciplinasMinistratadas;
            Titulacao = titulacao;
        }

        public Professor(int registroDoProfessor, Disciplina disciplinasMinistratadas, string titulacao)
        {
            RegistroDoProfessor = registroDoProfessor;
            DisciplinasMinistratadas = disciplinasMinistratadas;
            Titulacao = titulacao;
        }
    }
}