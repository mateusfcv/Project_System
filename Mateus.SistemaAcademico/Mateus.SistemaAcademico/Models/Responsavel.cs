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

        public Responsavel(string nome, List<Telefone> telefone, List<Endereco> endereco, string cpf,
            List<Aluno> aluno, int alunoId)
            :base(nome, telefone, endereco, cpf)
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