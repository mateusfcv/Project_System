using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Aluno : Pessoa
    {
        [Required]
        public int RegistroDoAluno { get; set; }

        public int ResponsavelId { get; set; }
        public virtual Responsavel Responsaveis { get; set; }

        [Required]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }

        public Aluno()
        {

        }

        public Aluno(string nome, List<Telefone> telefones, List<Endereco> enderecos, string cpf,
            int registroDoAluno, int responsavelId, Responsavel responsaveis, int cursoId, Curso curso)
            :base(nome, telefones, enderecos, cpf)
        {
            RegistroDoAluno = registroDoAluno;
            ResponsavelId = responsavelId;
            Responsaveis = responsaveis;
            CursoId = cursoId;
            Curso = curso;
        }
    }
}  