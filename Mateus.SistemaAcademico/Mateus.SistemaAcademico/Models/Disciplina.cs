using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Disciplina : EntityBase
    {
        public float CargaHoraria { get; set; }
        public string Nome { get; set; }
        public List<Conteudo> Conteudo { get; set; }
        public List<Curso> Curso { get; set; }

        public Disciplina ()
        {

        }

        public Disciplina(float cargaHoraria, string nome, List<Conteudo> conteudo, List<Curso> curso)
        {
            CargaHoraria = cargaHoraria;
            Nome = nome;
            Conteudo = conteudo;
            Curso = curso;
        }
    }
}