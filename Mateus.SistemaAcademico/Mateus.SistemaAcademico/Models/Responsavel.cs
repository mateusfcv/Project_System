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

        public Responsavel(string nome, string email, string cpf, DateTime dataDeNascimento, List<Telefone> telefones, List<Endereco> enderecos,
            EstadoCivil estadoCivil, Escolaridade escolaridade, List<Aluno> alunos)
            :base(nome, email, cpf, dataDeNascimento, telefones, enderecos)
        {
            EstadoCivil = estadoCivil;
            Escolaridade = escolaridade;
            Alunos = alunos;
        }
    }
}