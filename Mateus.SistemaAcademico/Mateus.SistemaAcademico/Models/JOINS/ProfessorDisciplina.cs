using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models.Joins
{
    public class ProfessorDisciplina
    {
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}