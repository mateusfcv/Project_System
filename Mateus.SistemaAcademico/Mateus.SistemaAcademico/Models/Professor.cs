using Mateus.SistemaAcademico.Models.Joins;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Professor : Pessoa
    {
        public IList<ProfessorCurso> Curso { get; set; }

        [Required]
        public int RegistroDoProfessor { get; set; }
        //[Required]
        //public Disciplina DisciplinasMinistratadas { get; set; }
        [Required]
        public string Titulacao { get; set; }

        public Professor ()
        {

        }

        public Professor(string nome, List<Telefone> telefones, List<Endereco> enderecos, string cpf,
            IList<ProfessorCurso> curso, int registroDoProfessor, string titulacao)
            :base(nome, telefones, enderecos, cpf)
        {
            Curso = curso;
            RegistroDoProfessor = registroDoProfessor;
            Titulacao = titulacao;
        }
    }
}