using Mateus.SistemaAcademico.Bussines;
using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico
{
    public class Endereco : EntityBase 
    {
        public string Cep { get; set; }
        public string NomeRua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estados { get; set; }
        public string Cidades { get; set; }

        public Endereco()
        {

        }

        public Endereco(string cep, string nomeRua, int numero, string complemento, string bairro, string estados, string cidades)
        {
            //if (Bairro == null || Complemento == null)
            //{
            //    throw new CampoNullException();
            //}
            //else
            {
                Cep = cep;
                NomeRua = nomeRua;
                Numero = numero;
                Complemento = complemento;
                Bairro = bairro;
                Estados = estados;
                Cidades = cidades;
            }
            
        }
    }
}