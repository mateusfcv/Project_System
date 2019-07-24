using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Alunos : Pessoa

    {
        public int Matricula { get; set; }

        //public Responsavel responsavel;

        public Alunos(string CPF, string nome, Endereco endereco, Telefones telefone) : base(CPF, nome, endereco, telefone)
        {

        }

        public void AssistirAulas()
        {

        }

        public void RealizarTrabalhos()
        {

        }

        public void RealizarProvas()
        {

        }

        public void VisualizarNotas()
        {

        }

        public void VisualizarFrequencia()
        {

        }
    }
}