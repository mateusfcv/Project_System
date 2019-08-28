using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models.Joins
{
    public class CursoDisciplina
    {
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }

        public CursoDisciplina()
        {

        }

        public CursoDisciplina(Curso curso, Disciplina disciplina)
        {
            Curso = curso;
            Disciplina = disciplina;
        }
    }
}