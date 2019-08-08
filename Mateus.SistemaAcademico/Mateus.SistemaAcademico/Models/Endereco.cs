using Mateus.SistemaAcademico.Bussines;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Endereco : EntityBase
    {
       [Required]
        public int CEP { get; set; }
        [Required]
        public int Numero { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        
      
        public Endereco(int cep)
        {
            CEP = cep;
            //Inserir codigo para inserir outrso campos baseados no CEP
        }
         
        public Endereco(int numero, string logradouro, string bairro, string complemento)
        {
            if (Logradouro == null || Bairro == null || Complemento == null)
            {
                throw new CampoNullException();
            }
            else
            {
                Numero = numero;
                Logradouro = logradouro;
                Bairro = bairro;
                Complemento = complemento;
            }
        }

        public static implicit operator List<object>(Endereco v)
        {
            throw new NotImplementedException();
        }
    }
}