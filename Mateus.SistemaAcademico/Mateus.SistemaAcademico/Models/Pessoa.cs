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
        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public string Cpf { get; set; }

        public Pessoa ()
        { 

        }

        protected Pessoa(string nome, List<Telefone> telefones, List<Endereco> enderecos, string cpf)
        {
            Nome = nome;
            Telefones = telefones;
            Enderecos = enderecos;
            Cpf = cpf;
        }
    }
}
