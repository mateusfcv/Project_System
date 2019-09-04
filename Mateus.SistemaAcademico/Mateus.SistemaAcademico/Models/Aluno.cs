using Mateus.SistemaAcademico.Bussines;
using Mateus.SistemaAcademico.Models.Enums;
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

        public virtual IEnumerable<Nota> Notas { get; set; }

        public Aluno()
        {

        }

        public Aluno(string nome, string email, string cpf, DateTime dataDeNascimento, int numeroTel,
            TipoTelefone tipoTelefone, string cep, string nomeRua, int numero, string complemento, string bairro,
            string estados, string cidades,
            int responsavelId, Responsavel responsavel, int cursoId, Curso curso, IEnumerable<Nota> notas)
            :base(nome, email, cpf, dataDeNascimento, numeroTel,
            tipoTelefone, cep, nomeRua, numero, complemento, bairro,
            estados, cidades)
        {
            ResponsavelId = responsavelId;
            Responsavel = responsavel;
            CursoId = cursoId;
            Curso = curso;
            Notas = notas;
        }

        public override bool ValidaData(Pessoa pessoa)
        {
            var dataatual = DateTime.Now;
            int resultado = DateTime.Compare(pessoa.DataDeNascimento, dataatual);

            if (resultado < 0 || resultado == 0)
            {
                return true;
            }
            return false;
        }
    }
}  