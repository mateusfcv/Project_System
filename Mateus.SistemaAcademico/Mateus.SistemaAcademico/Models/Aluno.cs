using Mateus.SistemaAcademico.Models.JOINS;
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

        public virtual Responsavel Responsavel { get; set; }
        public int ResponsavelId { get; set; }

        public virtual Frequencia Frequencia { get; set; }
        public int FrequenciaId { get; set; }

        public Curso Curso { get; set; }

        public Aluno()
        {

        }

        public Aluno(string nome, List<Telefone> telefone, List<Endereco> endereco, string cpf,
            int registroDoAluno, Responsavel responsavel, int responsavelId, Frequencia frequencia, int frequenciaId, Curso curso)
            :base(nome, telefone, endereco, cpf)
        {
            RegistroDoAluno = registroDoAluno;
            Responsavel = responsavel;
            ResponsavelId = responsavelId;
            Frequencia = frequencia;
            FrequenciaId = frequenciaId;
            Curso = curso;
        }

        public Aluno(int registroDoAluno, Responsavel responsavel, int responsavelId, Frequencia frequencia, int frequenciaId, Curso curso)
        {
            RegistroDoAluno = registroDoAluno;
            Responsavel = responsavel;
            ResponsavelId = responsavelId;
            Frequencia = frequencia;
            FrequenciaId = frequenciaId;
            Curso = curso;
        }
    }
}