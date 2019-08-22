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
        public IList<ProfessorDisciplina> Disciplinas { get; set; }

        [Required]
        public string Titulacao { get; set; }

        public Professor ()
        {

        }

        public Professor(string nome, string email, string cpf, DateTime dataDeNascimento, List<Telefone> telefones, List<Endereco> enderecos,
            IList<ProfessorCurso> curso, IList<ProfessorDisciplina> disciplinas, string titulacao)
            :base(nome, email, cpf, dataDeNascimento, telefones, enderecos)
        {
            Curso = curso;
            Disciplinas = disciplinas;
            Titulacao = titulacao;
        }
    }
}