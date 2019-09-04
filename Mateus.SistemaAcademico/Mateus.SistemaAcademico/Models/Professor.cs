using Mateus.SistemaAcademico.Models.Enums;
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


        public Professor ()
        {

        }

        public Professor(string nome, string email, string cpf, DateTime dataDeNascimento, int numeroTel,
            TipoTelefone tipoTelefone, string cep, string nomeRua, int numero, string complemento, string bairro,
            string estados, string cidades,
            IList<ProfessorCurso> curso, List<Disciplina> disciplinas, string titulacao)
            :base(nome, email, cpf, dataDeNascimento, numeroTel, tipoTelefone, cep, nomeRua, numero, complemento, 
                 bairro, estados, cidades)
        {
            Curso = curso;
            Disciplinas = disciplinas;
            Titulacao = titulacao;
        }

        public override bool ValidaData(Pessoa pessoa)
        {
            var dataatual = DateTime.Now;
            int resultado = DateTime.Compare(pessoa.DataDeNascimento, dataatual);

            if (resultado < 0 || resultado == 0)
            {
                return true;
            }
            return false;
        }
    }
}