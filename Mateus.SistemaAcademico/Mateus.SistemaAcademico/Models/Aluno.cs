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
        // Fazer gerar um RA automatico
        [Required]
        public int RegistroDoAluno { get; set; }

        // botão para add Responsavel
        [NotMapped]
        public int ResponsavelId { get; set; }
        public virtual Responsavel Responsavel { get; set; }

        [Required]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }

        public virtual IEnumerable<Notas> Notas { get; set; }

        public Aluno()
        {

        }

        public Aluno(string nome, string email, string cpf, DateTime dataDeNascimento, List<Telefone> telefones, List<Endereco> enderecos,
            int registroDoAluno, int responsavelId, Responsavel responsavel, int cursoId, Curso curso, IEnumerable<Notas> notas)
            :base(nome, email, cpf, dataDeNascimento, telefones, enderecos)
        {
            RegistroDoAluno = registroDoAluno;
            ResponsavelId = responsavelId;
            Responsavel = responsavel;
            CursoId = cursoId;
            Curso = curso;
            Notas = notas;
        }
    }
}  