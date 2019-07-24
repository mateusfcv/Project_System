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
        public int Telefones { get; set; }
        public string Endereco { get; set; }
        public string CPF { get; set; }

        public override string ToString()
        {
            return $"Pessoa: {this.Nome}, {this.Telefones}, {this.Endereco}, {this.CPF}";
        }
    }
}