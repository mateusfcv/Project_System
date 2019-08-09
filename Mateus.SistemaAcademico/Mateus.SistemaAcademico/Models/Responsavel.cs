using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Responsavel : Pessoa
    {
        public virtual List<Aluno> Aluno { get; set; }
        public int AlunoId { get; set; }

        public Responsavel ()
        {

        }

        public Responsavel(string nome, int numero, int CEP, string cpf,
            List<Aluno> aluno, int alunoId)
            :base( nome,  numero,  CEP,  cpf)
        {
            Aluno = aluno;
            AlunoId = alunoId;
        }

        public Responsavel(List<Aluno> aluno, int alunoId)
        {
            Aluno = aluno;
            AlunoId = alunoId;
        }
    }
}