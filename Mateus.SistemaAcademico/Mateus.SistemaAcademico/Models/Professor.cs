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
        public virtual IList<ProfessorCurso> Curso { get; set; }
        [Required]
        public int RegistroDoProfessor { get; set; }
        [Required]
        public virtual Disciplina DisciplinasMinistratadas { get; set; }
        public int DisciplinaId { get; set; }
        [Required]
        public string Titulacao { get; set; }

        public Professor ()
        {

        }

        public Professor(string nome, List<Telefone> telefone, List<Endereco> endereco, string cpf,
            IList<ProfessorCurso> curso, int registroDoProfessor, Disciplina disciplinasMinistratadas, int disciplinaId, string titulacao)
            :base(nome, telefone, endereco, cpf)
        {
            Curso = curso;
            RegistroDoProfessor = registroDoProfessor;
            DisciplinasMinistratadas = disciplinasMinistratadas;
            DisciplinaId = disciplinaId;
            Titulacao = titulacao;
        }

        public Professor(IList<ProfessorCurso> curso, int registroDoProfessor, Disciplina disciplinasMinistratadas, int disciplinaId, string titulacao)
        {
            Curso = curso;
            RegistroDoProfessor = registroDoProfessor;
            DisciplinasMinistratadas = disciplinasMinistratadas;
            DisciplinaId = disciplinaId;
            Titulacao = titulacao;
        }
    }
}