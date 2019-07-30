using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Endereco : EntityBase
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int CEP { get; set; }
        public int Numero { get; set; }


        public Endereco()
        {

        }

        public Endereco(int cep)
        {
            this.CEP = cep;
            //Inserir codigo para inserir outros campos baseado no CEP
        }

        public Endereco(string Logradouro, string Bairro, string Complemento, int numero)
        {
            if (Logradouro == null || Bairro == null || Complemento == null)
            {
                throw new CampoNullException();
            }
            else
            {
                this.Logradouro = Logradouro;
                this.Bairro = Bairro;
                this.Complemento = Complemento;
                this.Numero = numero;
            }
        }
    }
}