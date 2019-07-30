using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Aluno : Pessoa
    {
        public int RegistroDoAluno { get; set; }
        public Responsavel Responsavel { get; set; }

        public Aluno()
        {

        }

        public Aluno(Nome nome, List<Telefone> telefone, Endereco endereco, Cpf cpf, int registroDoAluno, Responsavel responsavel)
            :base(nome, telefone, endereco, cpf)
        {
            RegistroDoAluno = registroDoAluno;
            Responsavel = responsavel;
        }

        public Aluno(int registroDoAluno, Responsavel responsavel)
        {
            RegistroDoAluno = registroDoAluno;
            Responsavel = responsavel;
        }
    } 
}