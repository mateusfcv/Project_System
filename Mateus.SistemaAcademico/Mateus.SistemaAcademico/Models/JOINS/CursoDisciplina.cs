using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models.JOINS
{
    public class CursoDisciplina
    {
        public int IdCurso { get; set; }
        public Curso Curso { get; set; }
        public int IdDisciplina { get; set; }
        public Disciplina Disciplina { get; set; } 
    }
}