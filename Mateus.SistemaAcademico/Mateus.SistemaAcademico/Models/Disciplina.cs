using Mateus.SistemaAcademico.Models.Joins;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Disciplina : EntityBase
    {
        public IList<CursoDisciplina> Curso { get; set; }
        public IList<ProfessorDisciplina> Professors { get; set; }

        public virtual List<Conteudo> Conteudo { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public TimeSpan CargaHoraria { get; set; }

        public virtual IEnumerable<Notas> Notas { get; set; }


        public Disciplina()
        {

        }

        public Disciplina(IList<CursoDisciplina> curso, IList<ProfessorDisciplina> professors, List<Conteudo> conteudo, string nome, 
            TimeSpan cargaHoraria, IEnumerable<Notas> notas)
        {
            Curso = curso;
            Professors = professors;
            Conteudo = conteudo;
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Notas = notas;
        }
    } 
}