using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Responsavel : Pessoa
    {
        public List<Aluno> Alunos { get; set; }

        public Responsavel()
        {

        }

        public Responsavel(string nome, List<Telefone> telefones, List<Endereco> enderecos, string cpf, List<Aluno> alunos)
            :base(nome, telefones, enderecos, cpf)
        {
            Alunos = alunos;
        }
    }
}