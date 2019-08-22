using Mateus.SistemaAcademico.Bussines;
using Mateus.SistemaAcademico.Models.Objects_Value;
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
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
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
        }
    }
}
