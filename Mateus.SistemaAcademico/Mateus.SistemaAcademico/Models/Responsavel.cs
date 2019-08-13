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

        public Responsavel(string nome, int CEP, int numero, string cpf, List<Aluno> alunos)
            :base( nome,  CEP,  numero,  cpf)
        {
            Alunos = alunos;
        }

        public Responsavel(List<Aluno> alunos)
        {
            Alunos = alunos;
        }
    }
}