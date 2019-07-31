using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public abstract class Pessoa : EntityBase
    {
        public string Nome { get; set; }
        public List<Telefone> Telefone { get; set; }
        public List<Endereco> Endereco { get; set; }
        public string Cpf { get; set; }

        public Pessoa ()
        { 

        }

        protected Pessoa(string nome, List<Telefone> telefone, List<Endereco> endereco, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Cpf = cpf;
        }
    }
}
