using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Secretaria : Pessoa
    {
       [Required]
       public List<Curso> Cursos { get; set; } = new List<Curso>();

        public Secretaria()
        {
            
        }

        public Secretaria(string nome, string email, string cpf, DateTime dataDeNascimento, int numeroTel,
            TipoTelefone tipoTelefone, string cep, string nomeRua, int numero, string complemento, string bairro,
            string estados, string cidades, List<Curso> cursos)
            :base(nome, email, cpf, dataDeNascimento, numeroTel, tipoTelefone, cep, nomeRua, numero, complemento, bairro,
            estados, cidades)
        {
            Cursos = cursos;
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