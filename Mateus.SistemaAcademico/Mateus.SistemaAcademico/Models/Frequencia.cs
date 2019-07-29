using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Frequencia
    {
        public int IdFrequencia { get; set; }
        public TipoFrequencia tipoFrequencia { get; set; }
        public DateTime Data { get; set; }
        public Disciplina disciplina { get; set; }
        public Aluno aluno { get; set; }

        public Frequencia ()
        {

        }

        public Frequencia(int idFrequencia, TipoFrequencia tipoFrequencia, DateTime data, Disciplina disciplina, Aluno aluno)
        {
            IdFrequencia = idFrequencia;
            this.tipoFrequencia = tipoFrequencia;
            Data = data;
            this.disciplina = disciplina;
            this.aluno = aluno;
        }
    }
}