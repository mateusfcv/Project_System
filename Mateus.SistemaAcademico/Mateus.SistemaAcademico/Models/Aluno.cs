using Mateus.SistemaAcademico.Bussines;
using Mateus.SistemaAcademico.Models.Objects_Value;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Aluno : Pessoa
    {
        // fazer a função para cadastrar um responsavel junto do cadastro de aluno
        [NotMapped]
        public int ResponsavelId { get; set; }
        public virtual Responsavel Responsavel { get; set; }

        [Required]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }

        public string NomeUsuario { get; set; }
        public string Senha { get; set; }

        public virtual IEnumerable<Nota> Notas { get; set; }

        public Aluno()
        {

        }

        public Aluno(string nome, string email, string cpf, DateTime dataDeNascimento, List<Telefone> telefones, List<Endereco> enderecos,
            int responsavelId, Responsavel responsavel, int cursoId, Curso curso, string nomeUsuario, string senha, IEnumerable<Nota> notas)
            :base(nome, email, cpf, dataDeNascimento, telefones, enderecos)
        {
            ResponsavelId = responsavelId;
            Responsavel = responsavel;
            CursoId = cursoId;
            Curso = curso;
            NomeUsuario = nomeUsuario;
            Senha = senha;
            Notas = notas;
        }
    }
}  