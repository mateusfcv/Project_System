using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public abstract class Pessoa : EntityBase
    {
        public Nome Nome { get; set; }
        public List<Telefone> Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Cpf Cpf { get; set; }

        public Pessoa ()
        { 

        }

        protected Pessoa(Nome nome, List<Telefone> telefone, Endereco endereco, Cpf cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Cpf = cpf;
        }
    }
}
