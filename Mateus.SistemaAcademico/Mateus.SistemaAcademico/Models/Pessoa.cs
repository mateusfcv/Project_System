using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public abstract class Pessoa  
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public string Cpf { get; set; }

        public Pessoa ()
        { 

        }

        public Pessoa(string nome, int CEP, int numero, string cpf)
        {
            Nome = nome;
            Telefones.Add(new Telefone(numero));
            Enderecos.Add(new Endereco(CEP));
            Cpf = cpf;
        }
    }
}
