using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public Telefones[] telefones { get; set; }
        public Endereco endereco { get; set; }
        public CPF cpf { get; set; }
        public Telefones telefone { get; set; }
        public string cPF { get; set; }

        public Pessoa(string cPF, string nome, Endereco endereco, Telefones telefone)
        {
            this.cPF = cPF;
            Nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }
    }
}
