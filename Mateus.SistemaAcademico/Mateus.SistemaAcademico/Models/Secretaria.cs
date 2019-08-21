using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Secretaria : Pessoa
    {

        public Secretaria()
        {

        }

        public Secretaria(string nome, string email, string cpf, DateTime dataDeNascimento, List<Telefone> telefones, List<Endereco> enderecos)
            :base(nome, email, cpf, dataDeNascimento, telefones, enderecos)
        {

        }
    }
}