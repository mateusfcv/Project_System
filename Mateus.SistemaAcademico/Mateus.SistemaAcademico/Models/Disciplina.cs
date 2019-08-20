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

        public virtual List<Conteudo> Conteudo { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public float CargaHoraria { get; set; }
        [Required]
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }


        public Disciplina()
        {

        }

        public Disciplina(IList<CursoDisciplina> curso, List<Conteudo> conteudo, string nome, float cargaHoraria, 
            int professorId, Professor professor)
        {
            Curso = curso;
            Conteudo = conteudo;
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ProfessorId = professorId;
            Professor = professor;
        }
    } 
}