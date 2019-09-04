using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Responsavel : Pessoa
    {
        [Required]
        public EstadoCivil EstadoCivil { get; set; }
        [Required]
        public Escolaridade Escolaridade { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Responsavel()
        {

        }

        public Responsavel(string nome, string email, string cpf, DateTime dataDeNascimento, int numeroTel,
            TipoTelefone tipoTelefone, string cep, string nomeRua, int numero, string complemento, string bairro,
            string estados, string cidades, EstadoCivil estadoCivil, Escolaridade escolaridade, List<Aluno> alunos)
            :base(nome, email, cpf, dataDeNascimento, numeroTel, tipoTelefone, cep, nomeRua, numero, complemento,
                 bairro, estados, cidades)
        {
            EstadoCivil = estadoCivil;
            Escolaridade = escolaridade;
            Alunos = alunos;
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