using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Administrador : Pessoa
    {
        public Administrador()
        {

        }

        public Administrador(string nome, string email, string cpf, DateTime dataDeNascimento, int numeroTel,
            TipoTelefone tipoTelefone, string cep, string nomeRua, int numero, string complemento, string bairro,
            string estados, string cidades)
            :base(nome, email, cpf, dataDeNascimento, numeroTel, tipoTelefone, cep, nomeRua, numero, complemento, bairro,
            estados, cidades)
        {

        }

        public override bool ValidaData(Pessoa pessoa)
        {
            var dataatual = DateTime.Now;
            int resultado = DateTime.Compare(pessoa.DataDeNascimento, dataatual);

            if (resultado < 0 || resultado == 0)
            {
                return true;
            }
            return false;
        }
    }
}