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
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
        [Required] 
        public string Titulacao { get; set; }

        public string NomeUsuario { get; set; }
        public string Senha { get; set; }

        public Professor ()
        {

        }

        public Professor(string nome, string email, string cpf, DateTime dataDeNascimento, List<Telefone> telefones, List<Endereco> enderecos,
            IList<ProfessorCurso> curso, List<Disciplina> disciplinas, string titulacao, string nomeUsuario, string senha)
            :base(nome, email, cpf, dataDeNascimento, telefones, enderecos)
        {
            Curso = curso;
            Disciplinas = disciplinas;
            Titulacao = titulacao;
            NomeUsuario = nomeUsuario;
            Senha = senha;
        }
    }
}