using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models.JOINS
{
    public class ProfessorCurso
    {
        public virtual Professor Professor { get; set; }
        public int ProfessorId { get; set; }
        public virtual Curso Curso { get; set; }
        public int CursoId {get; set;}
    }
}