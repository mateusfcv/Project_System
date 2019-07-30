using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Responsavel : Pessoa
    {
        public Responsavel ()
        {

        }

        public Responsavel(Nome nome, List<Telefone> telefone, Endereco endereco, Cpf cPF)
            :base(nome, telefone, endereco, cPF)
        {
            
        }
    }
}