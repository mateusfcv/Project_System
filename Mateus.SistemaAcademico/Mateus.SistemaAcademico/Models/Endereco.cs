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
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int CEP { get; set; }
        public int Numero { get; set; }

        public Endereco(int CEP)
        {
            this.CEP = CEP;
            //Inserir codigo para inserir outros campos baseado no Cep
        }

        public Endereco(string lograddouro, string bairro, string complemento, int numero)
        {
            if (lograddouro == null || bairro == null || complemento == null)
            {
                throw new CampoNullException();
            }
            else
            {
                Logradouro = lograddouro;
                Bairro = bairro;
                Complemento = complemento;
                Numero = numero;
            }
        } 
    }
}