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
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O email é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O cpf é obrigatório.")]
        public string Cpf { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [Required]
        public DateTime DataDeNascimento { get; set; }

        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }
        

        public Pessoa ()
        { 

        }

        protected Pessoa(string nome, string email, string cpf, DateTime dataDeNascimento, List<Telefone> telefones,
            List<Endereco> enderecos)
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
