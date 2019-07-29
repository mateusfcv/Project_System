using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Responsavel : Pessoa
    {
        public int IdResponsavel { get; set; }
        public Responsavel ()
        {

        }

        public Responsavel(int idPessoa, Nome nome, List<Telefone> telefone, Endereco endereco, CPF cPF, int idResponsavel)
            :base(idPessoa, nome, telefone, endereco, cPF)
        {
            IdResponsavel = idResponsavel;
        }

        public Responsavel(int idResponsavel)
        {
            IdResponsavel = idResponsavel;
        }
    }
}