using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public abstract class Pessoa : EntityBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }
        

        public Pessoa ()
        { 

        }

        protected Pessoa(string nome, string email, string cpf, DateTime dataDeNascimento, List<Telefone> telefones, List<Endereco> enderecos)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataDeNascimento = dataDeNascimento;
            Telefones = telefones;
            Enderecos = enderecos;
        }
    }
}
