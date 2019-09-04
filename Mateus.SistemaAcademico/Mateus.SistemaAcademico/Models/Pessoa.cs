using Mateus.SistemaAcademico.Bussines;
using Mateus.SistemaAcademico.Models.Enums;
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

        [Required(ErrorMessage = "Você deve informar o cpf")]
        [Cpf(ErrorMessage = "Cpf inválido")]
        public string Cpf { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [Required]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        public int NumeroTel { get; set; }
        [Required]
        public TipoTelefone TipoTelefone { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        [Required]
        public string Cep { get; set; }
        [Required]
        public string NomeRua { get; set; }
        [Required]
        public int Numero { get; set; }

        public string Complemento { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Estados { get; set; }
        [Required]
        public string Cidades { get; set; }


        public Pessoa()
        {

        }

        protected Pessoa(string nome, string email, string cpf, DateTime dataDeNascimento, int numeroTel,
            TipoTelefone tipoTelefone, string cep, string nomeRua, int numero, string complemento, string bairro,
            string estados, string cidades)
        {
            // Nome = nome;
            Email = email;
            Cpf = cpf;
            DataDeNascimento = dataDeNascimento;
            NumeroTel = numeroTel;
            TipoTelefone = tipoTelefone;
            Cep = cep;
            NomeRua = nomeRua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Estados = estados;
            Cidades = cidades;

            // validação de nome
            //var ValidacaoNome = new Nome();

            //if (ValidacaoNome.ValidacaoNome(nome) == false)
            //{
            //    throw new CampoInvalidException();
            //}
            //else
            //{
            //    Nome = nome;
            //}
        }
        public abstract bool ValidaData(Pessoa pessoa);

    }
}

