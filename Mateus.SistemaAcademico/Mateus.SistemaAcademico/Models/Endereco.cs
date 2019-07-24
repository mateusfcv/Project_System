using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int CEP { get; set; }
        public int numero;

        public Endereco(string Logradouro, string Bairro, string Complemento, int numero)
        {
            if (Logradouro == null || Bairro == null || Complemento == null)
            {
                throw new CampoNullException();
            }
            else
            {
                EnderecoId = EnderecoId;
                this.Logradouro = Logradouro;
                this.Bairro = Bairro;
                this.Complemento = Complemento;
                this.numero = numero;
            }
        }

        public Endereco()
        {

        }
    }
}