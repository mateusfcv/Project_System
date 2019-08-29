using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Usuario : EntityBase
    {
        [Required]
        public string Login { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

        public int ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }

        public int SecretariaId { get; set; }
        public virtual Secretaria Secretaria { get; set; }

        public TipoPessoa TipoPessoa { get; set; }

        public Usuario()
        {

        }

        public Usuario(string login, string senha, int alunoId, Aluno aluno, int professorId, Professor professor,
            int secretariaId, Secretaria secretaria, TipoPessoa tipoPessoa)
        {
            Login = login;
            Senha = senha;
            AlunoId = alunoId;
            Aluno = aluno;
            ProfessorId = professorId;
            Professor = professor;
            SecretariaId = secretariaId;
            Secretaria = secretaria;
            TipoPessoa = tipoPessoa;
        }
    }
}