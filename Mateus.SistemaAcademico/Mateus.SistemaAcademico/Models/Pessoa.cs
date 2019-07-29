using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public abstract class Pessoa
    {
        public int IdPessoa { get; set; }
        public Nome nome { get; set; }
        public List<Telefone> Telefone { get; set; }
        public Endereco endereco { get; set; }
        public CPF cPF { get; set; }

        public Pessoa ()
        { 

        }

        public Pessoa(int idPessoa, Nome nome, List<Telefone> telefone, Endereco endereco, CPF cPF)
        {
            IdPessoa = idPessoa;
            this.nome = nome;
            Telefone = telefone;
            this.endereco = endereco;
            this.cPF = cPF;
        }
    }
}
