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
        public virtual List<Aluno> Alunos { get; set; }
        public virtual IEnumerable<Nota> Notas { get; set; }
        
        [Required]
        public int ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public TimeSpan CargaHoraria { get; set; }

        public Disciplina()
        {

        }

        public Disciplina(IList<CursoDisciplina> curso, List<Conteudo> conteudo, List<Aluno> alunos, IEnumerable<Nota> notas,
            int professorId, Professor professor, string nome, TimeSpan cargaHoraria)
        {
            Curso = curso;
            Conteudo = conteudo;
            Alunos = alunos;
            Notas = notas;
            ProfessorId = professorId;
            Professor = professor;
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }
    } 
}