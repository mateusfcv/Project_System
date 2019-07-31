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

        public Responsavel(string nome, List<Telefone> telefone, List<Endereco> endereco, string cPF)
            :base(nome, telefone, endereco, cPF)
        {
            
        }
    }
}